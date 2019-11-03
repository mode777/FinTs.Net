namespace FinTsNet
{
    public class MessageReference : ElementGroup
    {
        [FinTsElement(0)]
        public AlphanumericElement DialogId { get; set; }
        [FinTsElement(1)]
        public NumericElement Number { get; set; }
    }
}
