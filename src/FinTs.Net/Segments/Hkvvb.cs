namespace FinTsNet
{


    public class Hkvvb : Segment
    {
        public Hkvvb()
        {
        }

        public Hkvvb(int segNum, string productId, string productVersion)
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
