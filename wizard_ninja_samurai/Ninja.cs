using System;

namespace wizard_ninja_samurai
{
    class Ninja
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get { return health; }
        }
        public Ninja(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 175;
            health = 100;
        }
        public Ninja(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;

        }


    }
}
