using System;
using System.Collections.Generic;

namespace Euler43
{
    public class Builder
    {
        /*Create a new Builder from old*/
        public Builder(Builder newbuilder, int xnew)
        {
            buildanumber = new List<int>(newbuilder.buildanumber);
            buildanumber.Insert(0, xnew);
            this.used = new int[10];
            Array.Copy(newbuilder.used, this.used, newbuilder.used.Length);
            Usedcheck.PopulateUsed(xnew, this.used);
        }
        /*Create a new builder from scratch*/
        public Builder(int x, int[] used)
        {
            buildanumber = new List<int>();
            this.used = used;
            buildanumber.Insert(0, x);
        }

        public int[] Used
        {
            get { return used; }
        }
        //returns the last number inserted
        public int Lastin()
        {
            return buildanumber[0];
        }
        //builds a complete number when requested: complete
        public Int64 Pandigitalcomplete()
        {
            string z = "";
            for (int i = 0; i < buildanumber.Count; i++)
            {
                if (i == 0)
                    z += buildanumber[i].ToString();
                else
                    z += (buildanumber[i] % 10).ToString();
            }
            return Convert.ToInt64(z);
        }

        private List<int> buildanumber;
        private int[] used;
    }
}
