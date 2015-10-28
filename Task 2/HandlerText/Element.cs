using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public abstract class Element
    {
        string Value { get; set; }
        public Element(string value)
        {
            Value = value;
        }
        public string GetValue()
        {
            return Value;
        }
    }
}
