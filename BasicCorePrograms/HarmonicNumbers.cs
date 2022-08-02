using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    using System;

    /// <summary>
    /// This is harmonic class
    /// </summary>
    public class Harmonic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Harmonic"/> class.
        /// </summary>
        public Harmonic()
        {
            Console.WriteLine("enter value for harmonic:");
            int noForHarmonic = Convert.ToInt32(Console.ReadLine());    // converting string value to int
            Utility utility = new Utility();
            double harmonicNo = utility.Harmonic(noForHarmonic);
            Console.WriteLine("Sum of harmonic list number" + harmonicNo);
        }
    }
}