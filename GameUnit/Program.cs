using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Unit unit = new Unit(5, 100);
            unit.Move();
        }
    }
}
