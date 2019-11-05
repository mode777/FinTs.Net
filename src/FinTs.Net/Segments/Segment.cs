using System.Linq;

namespace FinTsNet
{


    public class Identification : Segment
    {
        public SegmentHeader Header { get; set; }
        //public BankId BankId { get; set; }
        public AlphanumericElement CustomerId { get; set; }
        public AlphanumericElement SystemId { get; set; }
        public NumericElement Status { get; set; }
    }



    public abstract class Segment : CompoundElement, IFinTsElement
    {
        public void Parse(string str)
        {
            Parse(str.Split('+'));
        }
        
        public string Serialize()
        {
            var elements = GetChildren();

            var body = string.Join("+", elements.Select(x => x?.Serialize() ?? ""));

            return body;
        }                
    }
}
