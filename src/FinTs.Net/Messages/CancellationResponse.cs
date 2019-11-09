namespace FinTsNet
{
    public class CancellationResponse : Message
    {
        [FinTsElement(0)]
        public Hnhbk Header { get; set; }
        [FinTsElement(1)]
        public ResponseFeedback Feedback { get; set; }
        [FinTsElement(2)]
        public Hnhbs Footer { get; set; }
    }
}
