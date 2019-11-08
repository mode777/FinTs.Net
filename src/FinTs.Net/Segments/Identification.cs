namespace FinTsNet
{
    public class Identification : Segment
    {
        public Identification()
        {
        }

        public Identification(int number, int blz, string userId, string systemId = "0")
        {
            Header = new SegmentHeader("HKIDN", 2, number);
            BankId = new BankId(blz);
            CustomerId = new AlphanumericElement(userId);
            SystemId = new AlphanumericElement(systemId);
            Status = new NumericElement(1);
        }

        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public BankId BankId { get; set; }
        [FinTsElement(2)]
        public AlphanumericElement CustomerId { get; set; }
        [FinTsElement(3)]
        public AlphanumericElement SystemId { get; set; }
        [FinTsElement(4)]
        public NumericElement Status { get; set; }
    }
}
