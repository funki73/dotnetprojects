using System;

namespace wizard_ninja_samurai
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100){}

        public override int Attack(Human target)
        {
            //Provide an override Attack method to Ninja, which reduces the target by 
            //5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
            Random rand = new Random();
            int dmg = 5 * Dexterity;
            if(rand.Next(100) <= 20)
            dmg += 10;
            return base.Attack(target, dmg);
        }
        public void Steal(Human target)
            {
                //Ninja should have a method called Steal, reduces a target 
                //Human's health by 5 and adds this amount to its own health.
                health += base.Attack(target,10);
            }
    }
}
