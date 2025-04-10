using System.Runtime.CompilerServices;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            string romanMovement = ToRoman(movement);
            System.Console.WriteLine($"Unit moved {romanMovement} spaces.");
        }

        private string ToRoman(int number)
        {
            if (number < 1 || number > 3999)
                return "Invalid number";
            
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string romanNumeral = thousands[number / 1000] +
                                   hundreds[(number % 1000) / 100] +
                                   tens[(number % 100) / 10] +
                                   ones[number % 10];
            
            return romanNumeral;
        } 
    }
}
