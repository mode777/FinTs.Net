using System;

namespace FinTsNet
{
    public class Hnvsk : Segment
    {
        public Hnvsk()
        {
        }

        public Hnvsk(DateTime date, int blz, string userId, string systemId)
        {
            Header = new SegmentHeader("HNVSK", 3, 998);
            Profile = new SecurityProfile(1, "PIN");
            SecurityFunction = new NumericElement(998);
            SecurityRole = new NumericElement(1);
            SecurityId = new SecurityIdentification(systemId);
            SecurityDate = new SecurityDateTime(date);
            Encryption = new EncryptionAlgorithm();
            KeyName = new KeyName(blz, userId, "V");
            CompressionFunction = new NumericElement(0);
            Certificate = null;
        }

        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public SecurityProfile Profile { get; set; }
        [FinTsElement(2)]
        public NumericElement SecurityFunction { get; set; }
        [FinTsElement(3)]
        public NumericElement SecurityRole { get; set; }
        [FinTsElement(4)]
        public SecurityIdentification SecurityId { get; set; }
        [FinTsElement(5)]
        public SecurityDateTime SecurityDate { get; set; }
        [FinTsElement(6)]
        public EncryptionAlgorithm Encryption { get; set; }
        [FinTsElement(7)]
        public KeyName KeyName { get; set; }
        [FinTsElement(8)]
        public NumericElement CompressionFunction { get; set; }
        [FinTsElement(9)]
        public Certificate Certificate { get; set; }
    }
}
