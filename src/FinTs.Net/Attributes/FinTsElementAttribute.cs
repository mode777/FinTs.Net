using System;

namespace FinTsNet
{

    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class FinTsElementAttribute : Attribute
    {
        public int Order { get; }
        public object[] Parameters { get; set; }

        public FinTsElementAttribute(int order, params object[] parameters)
        {
            Order = order;
            Parameters = parameters;
        }
    }
}
