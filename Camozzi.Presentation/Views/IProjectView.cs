﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Views
{
    public interface IProjectView
    {
        event Action Ok;
        event Action Cancel;


    }
}
