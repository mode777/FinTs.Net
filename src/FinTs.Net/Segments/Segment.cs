using System.Linq;

namespace FinTsNet
{
    public class Identification : Segment
    {
        public SegmentHeader Header { get; set; }
        public BankId BankId { get; set; }
        public AlphanumericElement CustomerId { get; set; }
        public AlphanumericElement SystemId { get; set; }
        public NumericElement Status { get; set; }
    }



    public class BankId : ElementGroup
    {
        public BankId()
        {
        }

        public BankId(int id, int country = 280)
        {
            Id = new NumericElement(id);
            CountryCode = new NumericElement(country);
        }

        [FinTsElement(0)]
        public NumericElement CountryCode { get; set; }
        [FinTsElement(1)]
        public NumericElement Id { get; set; }
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
