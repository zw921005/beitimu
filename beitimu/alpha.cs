using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace beitimu
{
    class alpha
    {
        public static string getChar(int number)
        {
            char c = Convert.ToChar(65 + number);
            return c.ToString();
        }

        public static int getNumber(string str)
        {
            int number = Convert.ToInt32(Convert.ToChar(str));
            return number;
        }

    }
}
