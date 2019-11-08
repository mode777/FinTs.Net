namespace FinTsNet
{
    public class BankId : ElementGroup
    {
        public BankId()
        {
        }

        public BankId(int blz)
        {
            CountryCode = new NumericElement(280);
            BankCode = new NumericElement(blz);
        }

        [FinTsElement(0)]
        public NumericElement CountryCode { get; set; }
        [FinTsElement(1)]
        public NumericElement BankCode { get; set; }
    }
}
