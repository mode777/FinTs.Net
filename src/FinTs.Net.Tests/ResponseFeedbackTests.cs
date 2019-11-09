using System.Collections.Generic;
using Xunit;

namespace FinTsNet.Tests
{

    public class ResponseFeedbackTests
    {        
        public static ResponseFeedback CreateExample()
        {
            return new ResponseFeedback
            {
                Header = new SegmentHeader("HIRMG", 2, 0),
                Feedback = new List<Feedback>
                {
                    new Feedback
                    {
                        FeedbackCode = new DigitElement(4, 1),
                        FeebackText = new AlphanumericElement("this is a test"),
                        ReferenceElement = null,
                        FeedbackParameters = null
                    },
                    new Feedback
                    {
                        FeedbackCode = new DigitElement(4, 2341),
                        FeebackText = new AlphanumericElement("this is also a test"),
                        ReferenceElement = null,
                        FeedbackParameters = new List<AlphanumericElement>
                        {
                            new AlphanumericElement("a"),
                            new AlphanumericElement("b")
                        }
                    },
                }
            };
        } 

        [Fact]
        public void Test1()
        {
            var feedback1 = CreateExample();
            var serialized1 = feedback1.Serialize();

            var feedback2 = FinTsParser.Parse<ResponseFeedback>(serialized1);
            var serialized2 = feedback2.Serialize();

            Assert.Equal(serialized1, serialized2);
        }
    }
}
