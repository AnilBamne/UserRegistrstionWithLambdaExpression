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
        /// Default constructor
        /// </summary>
        public Patterns()
        {

        }

        public string message;

        /// <summary>
        /// Parameterised constructor
        /// </summary>
        /// <param name="message"></param>
        public Patterns(string message)
        {
            this.message = message;
        }

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



        /// <summary>
        /// Validating Entries : if message contains Happy -> Entry succesful or if Sad -> Unsuccessfull
        /// </summary>

        public string CheckForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForLastName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForEmail()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForMobile()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForPassword()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }


        public bool ValidatEmailSamples(String email)
        {
            string regex = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            return Regex.IsMatch(email, regex);
        }

        public string checkMultipleEntriesOfEmail(string email1, string email2, string email3, string email4)
        {
            Patterns p = new Patterns(message);
            bool emailForEntry1 = p.ValidatEmailSamples(email1);
            bool emailForEntry2 = p.ValidatEmailSamples(email2);
            bool emailForEntry3 = p.ValidatEmailSamples(email3);
            bool emailForEntry4 = p.ValidatEmailSamples(email4);
            if (emailForEntry1 && emailForEntry2 && emailForEntry3 && emailForEntry4)
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
    }
}
