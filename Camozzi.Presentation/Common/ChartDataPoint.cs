using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekPlanner;

namespace Camozzi.Presentation.Common
{
    public class ChartDataPoint
    {
        //public string State { get; set; }
        public States State {get; set; }
        public int Value { get; set; }
    }
}
