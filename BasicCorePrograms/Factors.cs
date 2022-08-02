using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    using System;

    /// <summary>
    /// class Factors defined
    /// </summary>
    public class Factors
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Factors"/> class.
        /// </summary>
        public Factors()
        {
            Console.WriteLine("Enter a value");
            int number = Convert.ToInt32(Console.ReadLine());       // converting string value to int
            //// creating Utility class object.
            Utility utility = new Utility();
            //// calling Primefactors method.
            utility.PrimeFactors(number);
        }
    }
}
