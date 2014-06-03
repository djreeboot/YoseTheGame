using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YoseTheGame.Models
{
    public class PrimeFactorsModel
    {
        public int number { get; set; }
        public List<int> decomposition { get; set; }

        public void Decompose()
        {
            decomposition = new List<int>();
            int temp = number;
            while (temp != 1)
            {
                temp /= 2;
                decomposition.Add(2);
            }
        }
    } 

}