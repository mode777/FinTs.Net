namespace FinTsNet
{
    public class KeyName : ElementGroup
    {
        public KeyName()
        {
        }

        public KeyName(int blz, string userId, string keyType)
        {
            CountryCode = new NumericElement(280);
            BankId = new NumericElement(blz);
            UserId = new AlphanumericElement(userId);
            Type = new AlphanumericElement(keyType);
            Number = new NumericElement(0);
            Version = new NumericElement(0);
        }

        [FinTsElement(0)]
        public NumericElement CountryCode { get; set; }
        [FinTsElement(1)]
        public NumericElement BankId { get; set; }

        [FinTsElement(2)]
        public AlphanumericElement UserId { get; set; }
        [FinTsElement(3)]
        public AlphanumericElement Type { get; set; }
        [FinTsElement(4)]
        public NumericElement Number { get; set; }
        [FinTsElement(5)]
        public NumericElement Version { get; set; }
    }
}
