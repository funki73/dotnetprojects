using System;

namespace dojodachi
{
    class Dachi
    {
        public string Name;
        public string Happiness;
        public string Fullness;
        public string Energy;
        public string Meals;

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