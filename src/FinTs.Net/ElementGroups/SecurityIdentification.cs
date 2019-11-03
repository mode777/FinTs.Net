namespace FinTsNet
{
    public class SecurityIdentification : ElementGroup
    {
        public SecurityIdentification()
        {
        }

        public SecurityIdentification(string systemId)
        {
            SecurityParty = new AlphanumericElement("1");
            CID = null;
            SystemId = new AlphanumericElement(systemId);
        }

        [FinTsElement(0)]
        public AlphanumericElement SecurityParty { get; set; }
        [FinTsElement(1)]
        public BinaryElement CID { get; set; }
        [FinTsElement(2)]
        public AlphanumericElement SystemId { get; set; }
    }
}
