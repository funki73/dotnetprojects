using System;

namespace dojodachi
{
    class Dachi
    {
        public string Name;
        public int Happiness;
        public int Fullness;
        public int Energy;
        public int Meals;

        public Dachi(string name)
            {
                Name = name;
                Happiness = 20;
                Fullness = 20;
                Energy = 50;
                Meals = 3;
            }
        public Dachi(string name, int hap, int ful, int ene, int mea)
        {
            Name = name;
            Happiness = hap;
            Fullness = ful;
            Energy = ene;
            Meals = mea;
        }
    }
}