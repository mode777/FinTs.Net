﻿using System.Linq;

namespace FinTsNet
{
    public class Message : CompoundElement, IFinTsElement
    {
        public void Parse(string str)
        {
            var input = FinTsParser.UnescapeInput(str);
            
            var body = input.Substring(0, input.Length - 1);
            
            Parse(body.Split('\''));
        }              

        public string Serialize()
        {
            var elements = GetChildren();

            var body = string.Join("'", elements.Select(x => x?.Serialize() ?? ""));

            return body + "'";
        }
    }
}
