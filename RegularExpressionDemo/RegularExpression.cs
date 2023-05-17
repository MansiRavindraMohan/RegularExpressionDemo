using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RegularExpressionDemo
{
    public class RegularExpression
    {
        public void FirstName(string firstName)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if(Regex.IsMatch(firstName, pattern))
            {
                Console.WriteLine("{0} is valid",firstName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", firstName);
            }
        }
        public void LastName(string lastName)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("{0} is valid", lastName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", lastName);
            }
        }
        public void PhoneNo(string phoneNumber)
        {
            string pattern = "^[5-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(phoneNumber, pattern))
            {
                Console.WriteLine("{0} is valid", phoneNumber);
            }
            else
            {
                Console.WriteLine("{0} is not valid", phoneNumber);
            }
        }
        public void Email(string email)
        {
            string pattern = "^[a-zA-Z0-9]+([._#][a-zA-Z0-9]+)*[@][a-zA-Z]+[.][A-Za-z]{2,}([.][a-z]{2})?$";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("{0} is valid", email);
            }
            else
            {
                Console.WriteLine("{0} is not valid", email);
            }
        }
    }
}

