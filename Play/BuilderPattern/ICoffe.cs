﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.BuilderPattern
{
    public interface ICoffe
    {
        String Name();
        IIncludeing Include();
        float Price();	
    }
}