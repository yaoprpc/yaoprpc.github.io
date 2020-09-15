using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GFPointCalc.Logic.Models
{
    public class Weapon
    {
        public string Name { get; set; }
        public WeaponRange Range { get; set; }
        public int Attacks { get; set; }
        public Dictionary<string,int> SpecialRules { get; set; }
        public List<string> ArmyRules { get; set; }

        public double GetCost()
        {
            return 0;
        }

        public override string ToString()
        {
            var specialRules = string.Join(", ", SpecialRules.Select(x => x.Key + (x.Value > 0 ? $"({x.Value})" : "")));
            if (specialRules.Length > 0)
            {
                specialRules = ", " + specialRules;
            }
            var armyRules = string.Join(", ", ArmyRules);
            if (armyRules.Length > 0)
            {
                armyRules = ", " + armyRules;
            }
            return $"({WeaponRangeToString(Range)}, A{Attacks}{specialRules}{armyRules}";
        }

        public static string WeaponRangeToString(WeaponRange range)
        {
            switch (range)
            {
                case WeaponRange.Melee:
                    return "Melee";
                case WeaponRange.Six:
                    return "6\"";
                case WeaponRange.Twelve:
                    return "12\"";
                case WeaponRange.Eighteen:
                    return "18\"";
                case WeaponRange.TwentyFour:
                    return "24\"";
                case WeaponRange.Thirty:
                    return "30\"";
                case WeaponRange.ThirtySix:
                    return "36\"";
                case WeaponRange.FourtyTwo:
                    return "42\"";
                case WeaponRange.FourtyEight:
                    return "48\"";
            }
            return "Melee";
        }
    }

    public enum WeaponRange 
    {
        Melee,
        Six,
        Twelve,
        Eighteen,
        TwentyFour,
        Thirty,
        ThirtySix,
        FourtyTwo,
        FourtyEight
    }
}
