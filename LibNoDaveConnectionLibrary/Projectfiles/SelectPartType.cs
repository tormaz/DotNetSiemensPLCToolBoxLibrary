﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibNoDaveConnectionLibrary.STEP7Projectfiles
{
    public enum SelectPartType
    {
        BlocksOfflineFolder = 1,
        CPUFolder = 2,
        SourceFolder = 3,
        SymbolTable = 4,
        S7ProgrammFolder = 5,
        BlocksOfflinePart = 1001, //Select a fb,fc,db,vat,...
        VariableTable = 1011,
        FunctionBlock = 1021,
        DataBlock = 1022,
        LibNoDaveValue = 2001,
    }
}