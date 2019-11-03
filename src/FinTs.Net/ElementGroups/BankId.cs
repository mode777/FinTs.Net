namespace FinTsNet
{
    public class BankId : ElementGroup
    {
        public BankId()
        {
        }

        public BankId(int id, int country = 280)
        {
            Id = new NumericElement(id);
            CountryCode = new NumericElement(country);
        }

        [FinTsElement(0)]
        public NumericElement CountryCode { get; set; }
        [FinTsElement(1)]
        public NumericElement Id { get; set; }
    }
}
