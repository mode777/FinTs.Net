namespace FinTsNet
{
    public class MessageFooter : Segment
    {
        public MessageFooter()
        {
        }

        public MessageFooter(int number, int segmentNum)
        {
            Header = new SegmentHeader("HNHBS", 1, segmentNum);
            MessageNumber = new NumericElement(number);
        }
        
        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public NumericElement MessageNumber { get; set; }
    }
}
