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
}
