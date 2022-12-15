using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrstionWithLambdaExpression
{
    public class UserDetails
    {
        //Regex pattern for First name and Last name validation
        public string regexForName = "^[A-Z][A-za-z]{2,}";

        /// <summary>
        /// Validating first name.
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns> true/false</returns>
        public bool FirstNameValidate(string firstName) => Regex.IsMatch(firstName, regexForName);  //UC1
        public bool LastNameValidate(string laststName) => Regex.IsMatch(laststName, regexForName);  //UC2
    }
}
