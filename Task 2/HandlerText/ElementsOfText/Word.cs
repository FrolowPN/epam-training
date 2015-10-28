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
        public bool BeginWithConsonant 
        { 
            get 
            {
                char[] vovels = new char[] { 'e', 'y', 'u', 'i', 'o', 'a', 'E', 'Y', 'U', 'I', 'O', 'A' };
                if (!vovels.Contains(Value[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }
        public Word(string value): base(value)
        {
        }

    }
}
