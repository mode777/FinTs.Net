namespace FinTsNet
{
    public class Certificate : ElementGroup
    {
        public Certificate()
        {
        }

        [FinTsElement(0)]
        public NumericElement Type { get; set; }
        [FinTsElement(1)]
        public BinaryElement Content { get; set; }
    }
}
