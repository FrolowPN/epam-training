using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Digit :IElement
    {
        string Value { get; set; }
        public Digit(string value)
        {
            Value = value;
        }
        public string GetValue()
        {
            return Value;
        }
    }
}
