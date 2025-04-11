using System.IO.Compression;

namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health 
        {
            get => base.Health;
            set
            {
                Health += XP;
            }
        }

        public override float Cost
        {
            get => AttackPower + XP;
        }

        public void Attack (Unit u)
        {
            if (u is MilitaryUnit enemy)
            {
                enemy.Health -= AttackPower;
                XP += 10;
                System.Console.WriteLine($"Attacked {enemy.GetType().Name} for",

                                        "{AttackPower} damage. Gained 10 XP.");
            }
        }
    }
}
