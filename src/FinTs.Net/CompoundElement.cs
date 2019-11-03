using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FinTsNet
{
    public abstract class CompoundElement
    {
        private static ConcurrentDictionary<Type, PropertyMetadata[]> MetadataLookup = new ConcurrentDictionary<Type, PropertyMetadata[]>();

        private readonly PropertyMetadata[] metadata;

        public CompoundElement()
        {
            metadata = MetadataLookup.GetOrAdd(this.GetType(), t => CollectMetadata(t));
        }

        private PropertyMetadata[] CollectMetadata(Type type)
        {
            return type.GetProperties()
                .Select(x => new PropertyMetadata
                {
                    Property = x,
                    Attribute = (FinTsElementAttribute)x.GetCustomAttributes(true)
                        .FirstOrDefault(y => y is FinTsElementAttribute),
                    IsCollection = x.GetCustomAttributes(true)
                        .Any(y => y is FinTsCollectionAttribute)
                })
                .Where(x => x.Attribute != null)
                .OrderBy(x => x.Attribute.Order)
                .ToArray();
        }

        private class PropertyMetadata
        {
            public PropertyInfo Property { get; set; }
            public FinTsElementAttribute Attribute { get; set; }
            public bool IsCollection { get; set; }
        }

        protected IEnumerable<IFinTsElement> GetChildren()
        {
            foreach (var meta in metadata)
            {
                if (meta.IsCollection)
                {
                    var collection = (IEnumerable<IFinTsElement>)meta.Property.GetValue(this);
                    if(collection == null)
                    {
                        yield return null;
                        continue;
                    }

                    foreach (var item in collection)
                    {
                        yield return item;
                    }
                }
                else
                {
                    yield return (IFinTsElement)meta.Property.GetValue(this);
                }

            }
        }

        protected void Parse(string[] segments)
        {
            PropertyMetadata meta = null;
            for (int i = 0; i < segments.Length; i++)
            {
                meta = i < metadata.Length 
                    ? metadata[i]
                    : meta;

                var segment = segments[i];

                if (!(meta?.IsCollection ?? true))
                {                    
                    if (string.IsNullOrEmpty(segment))
                    {
                        meta.Property.SetValue(this, null);
                    }
                    else
                    {
                        var element = FinTsParser.Parse(meta.Property.PropertyType, segment, meta.Attribute.Parameters);
                        meta.Property.SetValue(this, element);
                    }
                }
                else
                {
                    var elementType = meta.Property.PropertyType.GenericTypeArguments[0];

                    var element = FinTsParser.Parse(elementType, segment, meta.Attribute.Parameters);
                    
                    var collection = meta.Property.GetValue(this);
                    if(collection == null)
                    {
                        var collectionType = typeof(List<>).MakeGenericType(elementType);
                        collection = Activator.CreateInstance(collectionType);
                        meta.Property.SetValue(this, collection);
                    }

                    var addMethod = collection.GetType().GetMethod("Add");

                    addMethod.Invoke(collection, new[] { element });
                }                
            }
        }

    }
}
