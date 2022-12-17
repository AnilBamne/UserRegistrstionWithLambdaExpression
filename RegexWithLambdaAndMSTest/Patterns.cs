using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexWithLambdaAndMSTest
{
    public class Patterns
    {
        /// <summary>
        /// Validating Regex patterns with Ms test
        /// uc1:First name
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public bool FirstName(string firstName)
        {
            string regex = "^[A-Z]{1}[a-zA-z]{2,}$";
            bool result = Regex.IsMatch(firstName, regex);
            return result;
        }
        ///uc2:Last name
        public bool LastName(string lastName)
        {
            string regex = "^[A-Z]{1}[a-zA-z]{2,}$";
            bool result = Regex.IsMatch(lastName, regex);
            return result;
        }
        ///uc3:Email
        public bool Email(string email)
        {
            string regex = "^[a-z]{3,}[.][a-z]{3,}[@]{1}[a-z]{2,}[.][a-z]{2,}[.][a-z]{2,}$";
            bool result = Regex.IsMatch(email, regex);
            return result;
        }
        ///uc4:Mobuile number
        public bool MobileNum(string mobile)
        {
            string regex = "^[9]{1}[1]{1}[\\s][7-9]{1}[0-9]{9}$";
            bool result = Regex.IsMatch(mobile, regex);
            return result;
        }
        ///uc5 - uc8 :PassWord all rules
        public bool Password(string password)
        {
            string regex = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]{1}).{8}";
            bool result = Regex.IsMatch(password, regex);
            return result;
        }
    }
}
