namespace Regex_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Enter 1 for First Name\nEnter 2 for Last Name");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: //First Name
                    RegexCheck obj = new RegexCheck();
                    Console.WriteLine("Enter a FirstName");
                    string FirstName = Console.ReadLine();
                    obj.Name(FirstName);
                break;
                case 2: //Last Name
                    UC2_LastName CheckLastName = new UC2_LastName();
                    Console.WriteLine("Enter a LastName");
                    string LastName = Console.ReadLine();
                    CheckLastName.Name(LastName);
                    break;

                default:
                    Console.WriteLine("End Of the Programme");
                    break;

            }
        }
    }
}