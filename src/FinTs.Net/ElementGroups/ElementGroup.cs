using System.Linq;

namespace FinTsNet
{
    public abstract class ElementGroup : CompoundElement, IFinTsElement
    {      
        public void Parse(string str)
        {
            Parse(str.Split(':'));
        }
        
        public string Serialize()
        {
            var elements = GetChildren();
            return string.Join(":", elements.Select(x => x?.Serialize() ?? ""));
        }
    }
}
