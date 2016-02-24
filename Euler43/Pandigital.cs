/*
Class contains a list of pandigital builders and will start 
building numbers with the conditions when instantiated
*/
using System;
using System.Collections.Generic;

namespace Euler43
{
    class Pandigitalmanager
    {
        public Pandigitalmanager(int[] conditions)
        {
            if (conditions.Length == 8)
            {
                pandigitalbuilders = new List<Builder>();
                for (int i = conditions.Length - 1; i > -1; i--)
                {
                    masterusedlist = new int[10];
                    (new Threedigit(conditions[i])).Loadbuilders(pandigitalbuilders);
                }
            }
            else
            {
                Console.WriteLine("Give 8 conditions for a 10 digit pandigital");
                pandigitalbuilders = null;
            }
        }
        //prints pandigital
        public void PrintPandigital()
        {
            if (pandigitalbuilders != null)
            {
                foreach (Builder b in pandigitalbuilders)
                {
                    Console.Write(b.Pandigitalcomplete() + " ");
                }
            }
        }
        //gets the sum of all pandigitals
        public Int64 Getsum()
        {
            Int64 answer = 0;
            if (pandigitalbuilders != null)
            {
                foreach (Builder b in pandigitalbuilders)
                {
                    answer += b.Pandigitalcomplete();
                }
            }
            return answer;
        }
        //private bool zipwithmaster;
        private List<Builder> pandigitalbuilders;
        private int[] masterusedlist;
    }
}
