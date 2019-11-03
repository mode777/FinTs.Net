namespace FinTsNet
{
    public interface IDataElement<T> : IFinTsElement
    {
        T Value { get; set; }
    }
}
