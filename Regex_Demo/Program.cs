namespace Regex_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            Console.WriteLine("Enter 1 for First Name\nEnter 2 for Last Name\nEnter 3 for Email\nEnter 4 for MobileNumber\nEnter 5 for PassWord\nEnter 6 for PassWord AtLeast One UPPerCase\nEnter 7 for PassWord AtLeast One Number\nEnter 8 PassWord AtLeast OneSpecialCharacter\n Enter 9 For All Sample Emails");
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
                case 3: //ValidEmail
                    UC3_Email CheckEmail = new UC3_Email();
                    Console.WriteLine("Enter a EmailAdress");
                    string Email = Console.ReadLine();
                    CheckEmail.Name(Email);
                    break;
                case 4: //MobileNumber
                    UC4_MobileNumber checkMobileNumber = new UC4_MobileNumber();
                    Console.WriteLine("Enter a MobileNumber");
                    string Mobile = Console.ReadLine();
                    checkMobileNumber.Name(Mobile);
                    break;
                case 5: //PassWord Rule
                    UC5_PassWord password = new UC5_PassWord();
                    Console.WriteLine("Enter a PassWord");
                    string PassWord = Console.ReadLine();
                    password.Name(PassWord);
                    break;
                case 6: //PassWord At Least One UpperCase
                    UC6_PassWordAtLeastOneUpperCase Password = new UC6_PassWordAtLeastOneUpperCase();
                    Console.WriteLine("Enter a PassWord");
                    string UpperCasePassWord = Console.ReadLine();
                    Password.Name(UpperCasePassWord);
                    break;
                case 7: //PassWord At Least One Number
                    UC7_AtLeastOne_Number Password1 = new UC7_AtLeastOne_Number();
                    Console.WriteLine("Enter a PassWord");
                    string OneNumber = Console.ReadLine();
                    Password1.Name(OneNumber);
                    break;
                case 8: //PassWord At Least one Special Character
                    UC8_AtLeastSpecialCharacter SplChar = new UC8_AtLeastSpecialCharacter();
                    Console.WriteLine("Enter a PassWord");
                    string SpecialCharacter = Console.ReadLine();
                    SplChar.Name(SpecialCharacter);
                    break;
                case 9: //All Sample Emails
                    SampleEmails sampleemails = new SampleEmails();
                    Console.WriteLine("Enter a Sample Emails");
                    string Allemails = Console.ReadLine();
                    sampleemails.Name(Allemails);
                    break;
                default:
                    Console.WriteLine("End Of the Programme");
                    break;

            }
        }
    }
}