﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public struct ComboItem 
{
    public string Text;
    public Int64 Id;
    public override string ToString()
    {
        return Text;
    }
}
