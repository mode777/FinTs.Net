namespace FinTsNet
{
    public interface IFinTsElement
    {
        void Parse(string str);
        string Serialize();
    }
}
