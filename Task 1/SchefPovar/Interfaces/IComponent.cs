﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchefPovar
{
    public interface IComponent
    {
        string Name { get; }
        int CaloricContent { get; }

        string AllProperties{get;}

    }
}