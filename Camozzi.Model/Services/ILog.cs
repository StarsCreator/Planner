using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Model.Services
{
    public interface ILog
    {

        void Error(string text, Exception ex);
    }
}
