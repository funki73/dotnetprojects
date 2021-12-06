using System;

namespace wizard_ninja_samurai
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name, 3, 3, 3, 200){}

        public override int Attack(Human target)
        {
            //Provide an override Attack method to Samurai, which calls 
            //the base Attack and reduces the target to 0 if it has less than 
            //50 remaining health points.
            int HealthLeft = Attack(target);
            if(HealthLeft < 50)
            {
                target.Health = 0;
            }
            return HealthLeft;
        }

        public void Meditate()
        {
            //Samurai should have a method called Meditate, which when 
            //invoked, heals the Samurai back to full health
            health = 200;
        }
    }
}