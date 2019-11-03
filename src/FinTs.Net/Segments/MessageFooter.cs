namespace FinTsNet
{
    public class MessageFooter : Segment
    {
        public MessageFooter()
        {
        }

        public MessageFooter(int number)
        {
            Header = new SegmentHeader("HNHBS", 1);
            MessageNumber = new NumericElement(number);
        }
        
        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public NumericElement MessageNumber { get; set; }
    }
}
