using System.Linq;

namespace Euler43
{ 
    /*
    Some static helper functions to help with duplicate checking
    */
    class Usedcheck
    {
        //Populates int[] with ones to find unique number changes
        //unused = 0, used = 1 
        public static int Nonduplicates(int xleft, int x, int[] usedcheck)
        {
            int sumbefore = 0;
            for(int i = 0; i < usedcheck.Length; i++)
            { sumbefore += usedcheck[i]; }
            usedcheck[xleft % 10] = 1;
            usedcheck[(xleft % 100) / 10] = 1;
            usedcheck[xleft / 100] = 1;
            usedcheck[x % 10] = 1;
            int after = 0;
            for (int i = 0; i < usedcheck.Length; i++)
            { after += usedcheck[i]; }
            return after - sumbefore;
        }
        //Populates usedcheck for the initial number going into a new builder
        //, unused = 0, used = 1 
        public static void PopulateUsed(int xleft, int[] usedcheck)
        {
            usedcheck[xleft % 10] = 1;
            usedcheck[(xleft % 100) / 10] = 1;
            usedcheck[xleft / 100] = 1;
        }
    }
}
