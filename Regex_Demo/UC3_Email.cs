using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class UC3_Email
    {
        public void Name(string name)
        {
            const String Pattern = "^[a-z]+([.][a-z]+)*[@][a-z]{2,}[.][a-z]{2,3}([.][a-zA-Z]{2})?$";
            if (Regex.IsMatch(name, Pattern))
            {
                Console.WriteLine(name + " is a valid Email");

            }
            else
            {
                Console.WriteLine(name + " is a invalid Email");
            }
            Console.ReadLine();

        }
    }
}
