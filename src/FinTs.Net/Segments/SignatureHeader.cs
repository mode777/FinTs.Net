using System;

namespace FinTsNet
{
    public class SignatureHeader : Segment
    {
        public SignatureHeader()
        {
        }

        public SignatureHeader(int segNum, string controlRef, string systemId, DateTime date, int blz, string userId)
        {
            Header = new SegmentHeader("HNSHK", 4, segNum);
            SecurityProfile = new SecurityProfile(1, "PIN");
            SecurityFunction = new AlphanumericElement("999");
            SecurityControlReference = new AlphanumericElement(controlRef);
            SecurityArea = new AlphanumericElement("1");
            SecurityRole = new AlphanumericElement("1");
            SecurityIdentification = new SecurityIdentification(systemId);
            SecurityReferenceNumber = new NumericElement(1);
            SecurityDateTime = new SecurityDateTime(date);
            HashAlgorithm = new HashAlgorithm();
            SignatureAlgorithm = new SignatureAlgorithm();
            KeyName = new KeyName(blz, userId, "S");
        }

        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1)]
        public SecurityProfile SecurityProfile { get; set; }
        [FinTsElement(2)]
        public AlphanumericElement SecurityFunction { get; set; }
        [FinTsElement(3)]
        public AlphanumericElement SecurityControlReference { get; set; }
        [FinTsElement(4)]
        public AlphanumericElement SecurityArea { get; set; }
        [FinTsElement(5)]
        public AlphanumericElement SecurityRole { get; set; }
        [FinTsElement(6)]
        public SecurityIdentification SecurityIdentification { get; set; }
        [FinTsElement(7)]
        public NumericElement SecurityReferenceNumber { get; set; }
        [FinTsElement(8)]
        public SecurityDateTime SecurityDateTime { get; set; }
        [FinTsElement(9)]
        public HashAlgorithm HashAlgorithm { get; set; }
        [FinTsElement(10)]
        public SignatureAlgorithm SignatureAlgorithm { get; set; }
        [FinTsElement(11)]
        public KeyName KeyName { get; set; }
    }
}
