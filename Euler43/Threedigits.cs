using System;
using System.Collections.Generic;

namespace Euler43
{
    public class Threedigit
    {
        public Threedigit(int multiple)
        {
            this.multiple = multiple;
            multiples = new List<int>();
        }
        //populates the multiples list at instantiation//
        private void loadmultiples(int multiple)
        {
            int value = 0;
            while (value < (1000 - multiple) && multiple > 0)
            {
                value += multiple;
                //should give me 3 different int from check numbers
                int[] usedcheck = new int[10];
                //check all digits are unique
                if (Usedcheck.Nonduplicates(value, value, usedcheck) == 3)
                {
                    multiples.Add(value);
                }
            }
        }
        //populate the first instance of builder when builder is empty
        private void loademtybuilder(List<Builder> emptybuilders)
        {
            int value = 0;
            while (value < (1000 - multiple) && multiple > 0)
            {
                value += multiple;
                //should give 3 differnt int from check numbers
                int[] usedcheck = new int[10];
                if (Usedcheck.Nonduplicates(value, value, usedcheck) == 3)
                {
                    multiples.Add(value);
                    emptybuilders.Add(new Builder(value, usedcheck));
                }
            }
        }
        //Loads the builders List of builders with ne possibilities
        //, remove failed possibilities
        public void Loadbuilders(List<Builder> builders)
        {
            if (builders.Count != 0)
            {
                int[] masterused = new int[10];
                loadmultiples(multiple);
                int buildersize = builders.Count;
                for (int i = 0; i < multiples.Count; i++)
                {
                    for (int j = 0; j < buildersize; j++)
                    {
                        if ((builders[j].Lastin() / 10) == (multiples[i] % 100))
                        {
                            int[] usedcheck = new int[10];
                            Array.Copy(builders[j].Used, usedcheck, usedcheck.Length);
                            if (Usedcheck.Nonduplicates(multiples[i], builders[j].Lastin(), usedcheck) == 1)
                            {
                                builders.Add((new Builder(builders[j], multiples[i])));
                            }
                        }
                    }
                }
                builders.RemoveRange(0, buildersize);
            }
            else
            {
                loademtybuilder(builders);
            }
        }

        private List<int> multiples;
        private int multiple;
    }
}
