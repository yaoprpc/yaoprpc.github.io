using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GFPointCalc.Logic.Models
{
    public class Model
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int Defense { get; set; }

        public List<Weapon> Weapons { get; set; }

        public Dictionary<string,int> SpecialRules { get; set; }
        public Dictionary<string,int> ArmyRules { get; set; }

        public double GetCost()
        {
            return 0;
        }

        public override string ToString()
        {
            string weapons = string.Join(", ", Weapons.Select(x => x.ToString()));
            string specialRules = string.Join(", ", SpecialRules.Select(x => x.Key + (x.Value > 0 ? $"({x.Value})" : "")));
            if (specialRules.Length > 0)
            {
                specialRules = ", " + specialRules;
            }
            string armyRules = string.Join(", ", ArmyRules.Select(x => x.Key + (x.Value > 0 ? $"({x.Value})" : "")));
            if (armyRules.Length > 0)
            {
                armyRules = ", " + armyRules;
            }
            string rules = specialRules.Length > 0 || armyRules.Length > 0 ? "Special Rules: " : "";
            return $"{Name}, Quality: {Quality}+, Defense: {Defense}+, Equipment: {weapons}{rules}{specialRules}{armyRules}";
        }
    }
}
