using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexWithLambdaAndMSTest
{
    public class UserRegistrationRegex
    {
        public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAILPATTERN = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";
        public static string MOBILEPATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORDRULE = "^(?=.*[A-Z])(?=.*[@#$%&*!_.-=])(?=.*[0-9])[a-zA-Z0-9].{8,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EMAILPATTERN);
        }
        public bool ValidateMobileFormat(string mobileFormat)
        {
            return Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        }
        public bool ValidatePreDefinedPassword(string preDefinedPassword)
        {
            return Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
        }

        /// <summary>
        /// This is by using lambda expression for validating user first,last name and password,
        /// </summary>
        public Func<string, bool> isValidFirstName = firstName => Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidLastName = lastName => Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EMAILPATTERN);
        public Func<string, bool> isValidMobileNumber = mobileFormat => Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        public Func<string, bool> isValidPassword = preDefinedPassword => Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
    }
}
