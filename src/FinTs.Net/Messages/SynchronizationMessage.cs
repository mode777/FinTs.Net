using System;
using System.Collections.Generic;
using System.Text;

namespace FinTsNet.Messages
{
    public class SynchronizationMessage : Message
    {
        public SynchronizationMessage()
        {

        }

        public SynchronizationMessage(string systemId, DateTime date, int blz, string userId, string productId, string productVer, Hksyn.Query query, string pin)
        {
            var controlRef = "123456";

            SignatureHeader = new Hnshk(2, controlRef, systemId, date, blz, userId);
            Identification = new Hkidn(3, blz, userId, systemId);
            ProcessInit = new Hkvvb(4, productId, productVer);
            Sync = new Hksyn(5, query);
            SignatureFooter = new Hnsha(6, controlRef, pin);
        }

        [FinTsElement(0)]
        public Hnshk SignatureHeader { get; set; }
        [FinTsElement(1)]
        public Hkidn Identification { get; set; }
        [FinTsElement(2)]
        public Hkvvb ProcessInit { get; set; }
        [FinTsElement(3)]
        public Hksyn Sync { get; set; }
        [FinTsElement(4)]
        public Hnsha SignatureFooter { get; set; }
    }
}
