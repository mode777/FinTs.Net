namespace FinTsNet
{
    public class CancellationResponse : Message
    {
        [FinTsElement(0)]
        public MessageHeader Header { get; set; }
        [FinTsElement(1)]
        public ResponseFeedback Feedback { get; set; }
        [FinTsElement(2)]
        public MessageFooter Footer { get; set; }
    }
}
