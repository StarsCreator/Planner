using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Presentation.Injection
{
    public interface IPresenter
    {
        void Run();
    }

    public interface IPresenter<in TArg>
    {
        void Run(TArg argument);
    }

    public interface IPresenter<in TArg, in TArg2>
    {
        void Run(TArg argument, TArg2 argument2);
    }
}
