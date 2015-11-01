using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerText
{
    public interface ISentence
    {
        IList<IElement> Elements { get;  }
        bool Interrogative { get; }
        int CountWord { get; } 
        IList<IElement> GetElements();
        void SetElements(IList<IElement> elements);
    }
}
