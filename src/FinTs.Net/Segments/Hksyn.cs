namespace FinTsNet
{
    public class Hksyn : Segment
    {
        public Hksyn()
        {
        }

        public Hksyn(int segNum, Query query)
        {
            Header = new SegmentHeader("HKSYN", 3, segNum);
            QueryType = new NumericElement((int)query);
        }

        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public NumericElement QueryType { get; set; }

        public enum Query
        {
            SystemId = 0,
            MessageNum = 1,
            SignatureId = 2
        }
    }
}
