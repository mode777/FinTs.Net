namespace FinTsNet
{
    public class SegmentHeader : ElementGroup
    {
        public SegmentHeader()
        {
        }

        public SegmentHeader(string id, int version, int number, int? reference = null)
        {
            Id = new AlphanumericElement(id);
            SegmentNumber = new NumericElement(number);
            Version = new NumericElement(version);
            Reference = reference.HasValue ? new NumericElement(reference.Value) : null;
        }

        [FinTsElement(0)]
        public AlphanumericElement Id { get; set; }
        [FinTsElement(1)]
        public NumericElement SegmentNumber { get; set; }
        [FinTsElement(2)]
        public NumericElement Version { get; set; }
        [FinTsElement(3)]
        public NumericElement Reference { get; set; }
    }
}
