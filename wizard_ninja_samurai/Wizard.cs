using System;

namespace wizard_ninja_samurai
{
    class Wizard
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        private int intelligence;

        public int Health
        {
            get { return health; }
        }
        public Wizard(string name)
        {
            Name = name;
            Strength = 0;
            Intelligence = 25;
            Dexterity = 0;
            health = 50;
        }
        public Wizard(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public int Attack(Wizard target)
        {
            int dmg = Intelligence * 5;
            target.intelligence -= dmg;
            wizard.intel += dmg;
            Console.WriteLine($"{Name} attached {target.Name} for {dmg} damage});
            return target.intelligence;
        }
    }
}
