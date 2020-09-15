using System;
using System.Collections.Generic;
using System.Text;

namespace GFPointCalc.Logic.Models
{
    public class Force
    {
        public string Name { get; set; }
        public List<Unit> Units { get; set; }

        public int GetCost()
        {
            return 0;
        }
    }
}
