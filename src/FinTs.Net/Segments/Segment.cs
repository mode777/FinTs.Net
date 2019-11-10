using System.Linq;

namespace FinTsNet
{

    public abstract class Segment : CompoundElement, IFinTsElement
    {
        public virtual  void Parse(string str)
        {
            Parse(str.Split('+'));
        }
        
        public virtual string Serialize()
        {
            var elements = GetChildren().Reverse().SkipWhile(x => x == null).Reverse();

            var body = string.Join("+", elements.Select(x => x?.Serialize() ?? ""));

            return body;
        }                
    }
}
