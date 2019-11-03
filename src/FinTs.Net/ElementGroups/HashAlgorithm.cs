namespace FinTsNet
{
    public class HashAlgorithm : ElementGroup
    {
        public HashAlgorithm()
        {
            Usage = new NumericElement(1);
            Algorithm = new NumericElement(999);
            Identifier = new NumericElement(1);
            Value = null;
        }
                
        [FinTsElement(0)]
        public NumericElement Usage { get; set; }
        [FinTsElement(1)]
        public NumericElement Algorithm { get; set; }
        [FinTsElement(2)]
        public NumericElement Identifier { get; set; }
        [FinTsElement(3)]
        public BinaryElement Value { get; set; }
    }
}
