using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class UC6_PassWordAtLeastOneUpperCase
    {
        public void Name(string name)
        {
            const String Pattern = "^[A-Z]{1,}[a-z0-9]{7,15}$";
            if (Regex.IsMatch(name, Pattern))
            {
                Console.WriteLine(name + " is a valid PassWord");

            }
            else
            {
                Console.WriteLine(name + " is a invalid PassWord");
            }
            Console.ReadLine();

        }
    }
}
