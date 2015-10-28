using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public class Word : Element, IElement
    {
        public int CountLetter { get { return Value.Length; } }
        public Word(string value): base(value)
        {
        }

    }
}
