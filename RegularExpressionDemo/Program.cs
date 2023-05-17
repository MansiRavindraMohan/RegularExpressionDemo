using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegularExpression regularExpression=new RegularExpression();
            regularExpression.FirstName("Mansi");
            regularExpression.LastName("Mohan");
            regularExpression.PhoneNo("7823985612");
            regularExpression.Email("abcdefg@gmail.com");
            Console.ReadLine();
        }
    }
}
