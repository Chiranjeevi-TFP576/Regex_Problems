namespace Regex_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Enter 1 for First Name");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: //First Name
                    RegexCheck obj = new RegexCheck();
                    Console.WriteLine("Enter a FirstName");
                    string FirstName = Console.ReadLine();
                    obj.Name(FirstName);
                   
                    break;
                default:
                    Console.WriteLine("End Of the Programme");
                    break;

            }
        }
    }
}