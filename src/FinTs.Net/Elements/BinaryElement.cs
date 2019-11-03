namespace FinTsNet
{
    public class BinaryElement : IDataElement<byte[]>, IFinTsElement
    {
        public byte[] Value { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Parse(string str)
        {
            throw new System.NotImplementedException();
        }

        public string Serialize()
        {
            throw new System.NotImplementedException();
        }
    }
}
