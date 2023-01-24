using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class UC4_MobileNumber
    {
        public void Name(string name)
        {
            const String Pattern = "^[1-9]{1}[0-9]{1,2}[ ][1-9][0-9]{9}$";
            if (Regex.IsMatch(name, Pattern))
            {
                Console.WriteLine(name + " is a valid MobileNumber");

            }
            else
            {
                Console.WriteLine(name + " is a invalid MobileNumber");
            }
            Console.ReadLine();

        }
    }
}
