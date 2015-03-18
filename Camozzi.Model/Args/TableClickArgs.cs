using System;

namespace Camozzi.Model.Args
{
    public class TableClickArgs:EventArgs
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
