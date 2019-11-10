namespace FinTsNet
{

    public class Hnhbk : Segment
    {
        public Hnhbk()
        {
        }

        public Hnhbk(int msgNum, int segNum = 1, int size = 0, string dialogId = "0",  int hbciVer = 300)
        {
            Header = new SegmentHeader("HNHBK", 3, segNum);
            Size = new DigitElement(12, size);
            HbciVersion = new NumericElement(hbciVer);
            DialogId = new AlphanumericElement(dialogId);
            MessageNumber = new NumericElement(msgNum);
            Reference = null;
        }

        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1, 12)]
        public DigitElement Size { get; set; }
        [FinTsElement(2)]
        public NumericElement HbciVersion { get; set; }
        [FinTsElement(3)]
        public AlphanumericElement DialogId { get; set; }
        [FinTsElement(4)]
        public NumericElement MessageNumber { get; set; }
        [FinTsElement(5)]
        public MessageReference Reference { get; set; }
    }
}
