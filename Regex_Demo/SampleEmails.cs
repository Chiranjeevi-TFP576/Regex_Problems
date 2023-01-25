using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class SampleEmails
    {
        public void Name(string name)
        {
            const String Pattern = "^[a-zA-Z0-9]+([@#%$&+.-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,})?$";
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
