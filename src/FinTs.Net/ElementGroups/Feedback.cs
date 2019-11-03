using System.Collections.Generic;

namespace FinTsNet
{
    public class Feedback : ElementGroup
    {
        [FinTsElement(0, 4)]
        public DigitElement FeedbackCode { get; set; }
        [FinTsElement(1)]
        public AlphanumericElement ReferenceElement { get; set; }
        [FinTsElement(2)]
        public AlphanumericElement FeebackText { get; set; }
        [FinTsElement(3), FinTsCollection()]
        public ICollection<AlphanumericElement> FeedbackParameters { get; set; }
    }
}