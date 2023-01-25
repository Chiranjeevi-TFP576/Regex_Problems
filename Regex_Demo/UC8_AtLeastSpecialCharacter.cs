using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class UC8_AtLeastSpecialCharacter
    {
        public void Name(string name)
        {
            const String Pattern = "^[A-Z]+[a-z]{4,16}[!@#$%&*]{1}[0-9]{3}$";
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
