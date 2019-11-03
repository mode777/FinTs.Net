namespace FinTsNet
{
    public class SecurityProfile : ElementGroup
    {
        public SecurityProfile()
        {
        }

        public SecurityProfile(int version, string method)
        {
            Method = new AlphanumericElement(method);
            Version = new NumericElement(version);
        }

        [FinTsElement(0)]
        public AlphanumericElement Method { get; set; }
        [FinTsElement(1)]
        public NumericElement Version { get; set; }

    }
}
