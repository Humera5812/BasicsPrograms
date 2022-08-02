using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{ 
    public class Utility
    {
        public static void CoinFlipped()
        {
            Console.WriteLine("Enter a no. of times coin to be fliped:");
            int noOfTimes = Convert.ToInt32(Console.ReadLine());            
            Utility utility = new Utility();
            utility.Flip(noOfTimes);
        }
        private void Flip(int nooFTimes)
        {
            
        }
    }
}