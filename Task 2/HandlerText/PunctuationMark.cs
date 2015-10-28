using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class PunctuationMark : IElement
    {
        string Value { get; set; }
        public PunctuationMark(string value)
        {
            Value = value;
        }
        public string GetValue()
        {
            return Value;
        }
    }
}
