namespace FinTsNet
{
    public class EncryptionAlgorithm : ElementGroup
    {
        public EncryptionAlgorithm()
        {
            Usage = new NumericElement(2);
            Mode = new NumericElement(2);
            Algorithm = new NumericElement(13);
            Data = new BinaryElement("00000000");
            KeyId = new NumericElement(5);
            IvId = new NumericElement(1);
            Iv = null;
        }

        [FinTsElement(0)]
        public NumericElement Usage { get; set; }
        [FinTsElement(1)]
        public NumericElement Mode { get; set; }
        [FinTsElement(2)]
        public NumericElement Algorithm { get; set; }
        [FinTsElement(3)]
        public BinaryElement Data { get; set; }
        [FinTsElement(4)]
        public NumericElement KeyId { get; set; }
        [FinTsElement(5)]
        public NumericElement IvId { get; set; }
        [FinTsElement(6)]
        public BinaryElement Iv { get; set; }
    }
}
