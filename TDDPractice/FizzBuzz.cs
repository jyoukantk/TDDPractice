using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public class FizzBuzz
    {
        public string ConvertString(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("0はNG");
            }

            if (value % 3 == 0)
            {
                return "Fizz";
            }

            if (value % 5 == 0)
            {
                return "Buzz";
            }

            return Convert.ToString(value);
        }
    }
}
