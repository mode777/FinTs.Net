namespace FinTsNet
{
    public class Hnsha : Segment
    {
        public Hnsha()
        {
        }

        public Hnsha(int segNum, string controlRef, string signature)
        {
            Header = new SegmentHeader("HNSHA", 2, segNum);
            ControlReference = new AlphanumericElement(controlRef);
            Result = null;
            Signature = new AlphanumericElement(signature);
        }

        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public AlphanumericElement ControlReference { get; set; }
        [FinTsElement(2)]
        public BinaryElement Result { get; set; }
        [FinTsElement(3)]
        public AlphanumericElement Signature { get; set; }
    }


    public class Hnvvb : Segment
    {
        public Hnvvb()
        {
        }

        public Hnvvb(int segNum, string productId, string productVersion)
        {
            Header = new SegmentHeader("HKVVB", 3, segNum);
            Bpd = new NumericElement(0);
            Upd = new NumericElement(0);
            Language = new NumericElement(0);
            ProductId = new AlphanumericElement(productId);
            ProductVersion = new AlphanumericElement(productVersion);
        }

        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public NumericElement Bpd { get; set; }
        [FinTsElement(2)]
        public NumericElement Upd { get; set; }
        [FinTsElement(3)]
        public NumericElement Language { get; set; }
        [FinTsElement(4)]
        public AlphanumericElement ProductId { get; set; }
        [FinTsElement(5)]
        public AlphanumericElement ProductVersion { get; set; }
    }
}
