﻿using Camozzi.Presentation.Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Views
{
    public interface ILoginView : IView
    {
        event Action Ok;

        string UserName { get; set; }
        string Password { get; }
        object Users { set; }

        void ClearPswFld();
    }
}
