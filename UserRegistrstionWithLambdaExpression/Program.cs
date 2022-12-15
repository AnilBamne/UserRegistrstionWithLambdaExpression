using System;

namespace UserRegistrstionWithLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registrstion With Lambda Expression programs");
            UserDetails user = new UserDetails();
            
            Console.WriteLine("Choose option\n1:First Name\n2:Last Name\n3:Email\n4:Phone number\n5:Password\n6:Email samples");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    bool result = user.FirstNameValidate();
                    Console.WriteLine(result);
                    break;
                case 2:
                    bool result1 = user.LastNameValidate();
                    Console.WriteLine(result1);
                    break;
                case 3:
                    bool result2 = user.Email();
                    Console.WriteLine(result2);
                    break;
                case 4:
                    bool result3 = user.PhoneNumber();
                    Console.WriteLine(result3);
                    break;
                case 5:
                    bool result4 = user.Password();
                    Console.WriteLine(result4);
                    break;
                case 6:
                    user.EmailSamples();
                    break;
            }
        }
    }
}
