using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Word : IElement
    {
        string Value { get; set; }
        public int CountLetter { get { return Value.Length; } }
        public Word(string value)
        {
            Value = value;
        }
        public string GetValue()
        {
            return Value;
        }
    }
}
