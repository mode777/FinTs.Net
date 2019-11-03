using System.Collections.Generic;

namespace FinTsNet
{

    public class ResponseFeedback : Segment
    {
        [FinTsElement(0)]
        public SegmentHeader Header { get; set; }
        [FinTsElement(1), FinTsCollection]
        public ICollection<Feedback> Feedback { get; set; }
    }
}
