﻿using Camozzi.Presentation.Injection;
using Camozzi.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Presenters
{
    public class MainPresenter: BasePresenter<IMainView>
    {
        public MainPresenter(IApplicationController controller, IMainView view):base(controller,view)
        {

        }
    }
}