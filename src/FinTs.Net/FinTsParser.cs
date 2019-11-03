using System;
using System.Reflection;

namespace FinTsNet
{
    public static class FinTsParser
    {
        public static T Parse<T>(string val)
            where T : IFinTsElement, new()
        {
            var el = new T();
            el.Parse(val);
            return el;
        } 

        public static IFinTsElement Parse(Type type, string val, object[] args)
        {
            var el = (IFinTsElement)Activator.CreateInstance(type, args);
            el.Parse(val);
            return el;
        }

        public static string UnescapeInput(string input)
        {
            return input.Replace("?+", "&plu;")
                .Replace("?:", "&col;")
                .Replace("?'", "&sq;")
                .Replace("??", "?")
                .Replace("?@", "&at;");
        }
    }
}
