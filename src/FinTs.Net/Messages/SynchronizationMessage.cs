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

        public SynchronizationMessage(string systemId, DateTime date, int blz, string userId)
        {

            SignatureHeader = new Hnshk(2, "123456", systemId, date, blz, userId);
            Identification = new Hkidn(3, blz, userId, systemId);
        }

        [FinTsElement(0)]
        public Hnshk SignatureHeader { get; set; }
        [FinTsElement(1)]
        public Hkidn Identification { get; set; }
    }
}
