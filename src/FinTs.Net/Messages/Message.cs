using System.Linq;

namespace FinTsNet
{
    public class Message : CompoundElement, IFinTsElement
    {
        public virtual void Parse(string str)
        {
            var input = FinTsParser.UnescapeInput(str);
            
            var body = input.Substring(0, input.Length - 1);
            
            Parse(body.Split('\''));
        }              

        public virtual string Serialize()
        {
            var elements = GetChildren().Reverse().SkipWhile(x => x == null).Reverse();

            var body = string.Join("'", elements.Select(x => x?.Serialize() ?? ""));

            return body + "'";
        }

        public virtual int Count()
        {
            return GetChildren().Count();
        }
    }
}
