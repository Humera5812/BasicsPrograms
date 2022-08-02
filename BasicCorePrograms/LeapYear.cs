using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   
    public class LeapYear
    {
        public void Leap()
        {
        validation:
            try
            {
                Console.WriteLine("enter a year(only 4 digits:)");
                int year = Convert.ToInt32(Console.ReadLine());     
                Utility utility = new Utility();
                bool result = utility.LeapYear(year);
                bool LeapYear(int Year);
                {
                    throw new NotImplementedException();
                }
                if (result)
                {
                    Console.WriteLine("this is leap year");
                }
                else
                {
                    Console.WriteLine("this is not leap year");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("WRONG INPUT\nPlease right input again");
                goto validation;
            }
        }
    }
}
