using System;

namespace FinTsNet
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class FinTsCollectionAttribute : Attribute
    {
    }
}
