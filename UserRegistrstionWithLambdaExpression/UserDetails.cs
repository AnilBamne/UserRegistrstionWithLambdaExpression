﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrstionWithLambdaExpression
{
    public class UserDetails
    {
        /// <summary>
        /// Using Lambda expression
        /// Validating is data is matching with regex pattern or not
        /// </summary>
        /// <param name="data"></param>
        /// <param name="regex"></param>
        /// <returns>true/false</returns>
        public bool Validate(string data,string regex) => Regex.IsMatch(data, regex);  //UC3

        /// <summary>
        /// Validating first name
        /// </summary>
        /// <returns></returns>
        public bool FirstNameValidate()     //UC1
        {
            string regex = "^[A-Z][A-za-z]{2,}";
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            return Validate(firstName, regex);
        }

        /// <summary>
        /// Validating last name
        /// </summary>
        /// <returns></returns>
        public bool LastNameValidate()      //UC2
        {
            string regex = "^[A-Z][A-za-z]{2,}";
            Console.WriteLine("Enter last name");
            string lasttName = Console.ReadLine();
            return Validate(lasttName, regex);
        }

        /// <summary>
        /// Validating email id
        /// Enter Email ID \n E.g. : abc.xyz@bl.co.in
        /// </summary>
        /// <returns></returns>
        public bool Email()     //UC3
        {
            string regex = "^[a-z]{3,}[.][a-z]{3,}[@][a-z]{2,}[.][a-z]{2}[.][a-z]{2}$";
            Console.WriteLine("Enter email");
            string email=Console.ReadLine();
           return Validate(email,regex);
        }

        /// <summary>
        /// Validating phone number
        /// </summary>
        /// <returns></returns>
        public bool PhoneNumber()       //UC4
        {
            string regex = "^[9]{1}[1]{1}[ ]{1}[6-9]{1}[0-9]{9}$";
            Console.WriteLine("Enter PhoneNumber");
            string PhoneNumber = Console.ReadLine();
            return Validate(PhoneNumber, regex);
        }

        /// <summary>
        /// Validating password all rules
        /// Password should have -> 1.Minimum 8 charecters, 2.Atleast 1 Upper case, 3.Atleast 1 Number and Exactly one Special char
        /// </summary>
        /// <returns></returns>
        public bool Password()      //UC5-8
        {
            string regex = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]{1}).{8}";
            Console.WriteLine("Enter password -> Password should have ->\n1.Minimum 8 charecters\n2.Atleast 1 Upper case\n3.Atleast 1 Number\n4.Exactly one Special char");
            string password = Console.ReadLine();
            return Validate(password, regex);
        }
    }
}
