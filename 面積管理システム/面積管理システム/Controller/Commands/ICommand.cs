﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面積管理システム.Controller.Commands
{
    interface ICommand
    {
        bool Run(object args);
    }
}
