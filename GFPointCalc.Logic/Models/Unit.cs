using System;
using System.Collections.Generic;
using System.Text;

namespace GFPointCalc.Logic.Models
{
    public class Unit
    {
        public string Name { get; set; }
        public List<Model> Models { get; set; }

        public int GetCost()
        {
            return 0;
        }
    }
}
