using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class program
    {
        public class Human
        {
            public enum monthofyr
            {
                January = 1, February, March
            }


            static void Main(string[] args)
            {
                Console.WriteLine("Month of Year{0} {1}", (int)monthofyr.January, monthofyr.January);
                Console.WriteLine("Month of Year{0} {1}", (int)monthofyr.January, (monthofyr)2);
                Console.WriteLine("Month of Year{0} {1}", (int)monthofyr.January, monthofyr.March);
                Console.ReadKey();
            }
        }
    }
}
