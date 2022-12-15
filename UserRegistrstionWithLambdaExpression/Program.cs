using System;

namespace UserRegistrstionWithLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registrstion With Lambda Expression programs");
            UserDetails user = new UserDetails();
            Console.WriteLine("Choose option\n1:First Name\n2:Last Name\n3:Email");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter first name");
                    string firstName=Console.ReadLine();
                    bool result = user.FirstNameValidate(firstName);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine("Enter last name");
                    string lastName=Console.ReadLine();
                    bool result1 = user.LastNameValidate(lastName);
                    Console.WriteLine(result1);
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
            
        }
    }
}
