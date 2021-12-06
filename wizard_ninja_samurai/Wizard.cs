using System;

namespace wizard_ninja_samurai
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50){}
        
        public override int Attack(Human target)
        {
        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence 
        //and heals the Wizard by the amount of damage dealt
            int cast = base.Attack(target, Intelligence * 5);
            health -= cast;
            return cast;
        }
        public void Heal(Human target)
        {
            // Wizard should have a method called Heal, which when invoked, heals a target Human by 
            // 10 * Intelligence
            int healttl = 10 * Intelligence;
            target.Health += healttl;
        }

        // public int Attack(Wizard target)
        // {
        //     int dmg = Intelligence * 5;
        //     target.intelligence -= dmg;
        //     wizard.intel += dmg;
        //     Console.WriteLine($"{Name} attached {target.Name} for {dmg} damage});
        //     return target.intelligence;
        // }
    }
}
