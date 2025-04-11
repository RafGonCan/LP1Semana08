using System;
using System.Runtime.CompilerServices;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 2),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(1, 3), 
            };

            (units[0] as MilitaryUnit).Attack(units[1]);
            (units[0] as MilitaryUnit).Attack(units[2]);
            (units[1] as SettlerUnit).Move();

            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }
        }
    }
}
