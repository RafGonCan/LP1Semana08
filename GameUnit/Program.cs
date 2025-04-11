using System;
using System.Runtime.CompilerServices;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            MilitaryUnit soldier = new MilitaryUnit(3, 10, 5);
            SettlerUnit settler = new SettlerUnit(1, 3);

            soldier.Move();
            settler.Move();
            Console.WriteLine($"Soldier Health: {soldier.Health}");
            Console.WriteLine($"Settler Health: {settler.Health}");
        }
    }
}
