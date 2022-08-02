using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    using System;

    /// <summary>
    /// this is class PowerOfTwo
    /// </summary>
    public class PowerOfTwo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerOfTwo"/> class.
        /// </summary>
        /// <param name="argument">The argument.</param>
        public PowerOfTwo(string argument)
        {
            Console.WriteLine("Take command-line argument");
            double number = Convert.ToInt32(argument);          // converting string value to int
            Utility utility = new Utility();
            Console.Write("[ ");

            for (int i = 0; i <= number; i++)
            {
                double result = utility.PowerOfTwo(i);
                Console.Write(result + " ");
            }

            Console.WriteLine("]");
        }
    }
}