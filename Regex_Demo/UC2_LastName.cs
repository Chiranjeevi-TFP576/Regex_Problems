using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class UC2_LastName
    {
        public void Name(string name)
        {
            const String Pattern = "^[A-Z]{1}[a-z]{2,}[ ][A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, Pattern))
            {
                Console.WriteLine(name + " is a valid Name");

            }
            else
            {
                Console.WriteLine(name + " is a invalid Name");
            }
            Console.ReadLine();

        }

    }
}
