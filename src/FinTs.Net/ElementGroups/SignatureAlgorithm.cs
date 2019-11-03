namespace FinTsNet
{
    public class SignatureAlgorithm : ElementGroup
    {

        public SignatureAlgorithm()
        {
            Usage = new NumericElement(6);
            Algorithm = new NumericElement(10);
            OperationMode = new NumericElement(16);
        }

        [FinTsElement(0)]
        public NumericElement Usage { get; set; }
        [FinTsElement(1)]
        public NumericElement Algorithm { get; set; }
        [FinTsElement(2)]
        public NumericElement OperationMode { get; set; }
    }
}
