using System;

namespace humanassignment
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        // Add a constructor to assign custom values to all fields
        // Build Attack method
        public int Health
        {
            get { return health; }
        }
        public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public int Attack(Human target)
        {
        int dmg = Strength * 3;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
        }
    }
}