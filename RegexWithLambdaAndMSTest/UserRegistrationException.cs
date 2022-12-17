using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexWithLambdaAndMSTest
{
    public class UserRegistrationException:Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_PHONE,
            INVALID_PASSWORD
        }
        public ExceptionType Type;
        public UserRegistrationException(ExceptionType type,string message):base(message)
        {
            Type = type;
        }
    }
}
