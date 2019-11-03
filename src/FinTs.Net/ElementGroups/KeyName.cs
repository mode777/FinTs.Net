namespace FinTsNet
{
    public class KeyName : ElementGroup
    {
        public KeyName()
        {
        }

        public KeyName(int blz, string userId, string keyType)
        {
            BankId = new BankId(blz);
            UserId = new AlphanumericElement(userId);
            Type = new AlphanumericElement(keyType);
            Number = new NumericElement(0);
            Version = new NumericElement(0);
        }

        [FinTsElement(0)]
        public BankId BankId { get; set; }
        [FinTsElement(1)]
        public AlphanumericElement UserId { get; set; }
        [FinTsElement(2)]
        public AlphanumericElement Type { get; set; }
        [FinTsElement(3)]
        public NumericElement Number { get; set; }
        [FinTsElement(4)]
        public NumericElement Version { get; set; }
    }
}
