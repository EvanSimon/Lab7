using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = NameValidation(); //call for name
            string emil = emailValidate(); //call for email
            string phone = phoneVal();//call for phone nrumbe
            string date = dateVal();// call for the date
            string html = htmlValidation();// call for html 
        }

        public static string NameValidation () // Name method
        {

            Console.WriteLine("Enter your name"); //input
           string userName = Console.ReadLine();

            while(!Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$")) // epression for name while loop is set to false
            {

                Console.WriteLine("Thats not a vaild name try agin ");//error message
                userName = Console.ReadLine();
            }


            return userName;

        }

        public static string emailValidate() //function for email
        {

            Console.WriteLine("Enter a email");//input for email
            string email = Console.ReadLine();

            while(!Regex.IsMatch(email, @"^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$")) //expression for email set to false
            {
                Console.WriteLine("Sorry a vaild email adress try agin");//error message

                email = Console.ReadLine();
            }

            return email;

        }

        public static string phoneVal()//function for phone number
        {

            Console.WriteLine("Enter a phone number ");// input for phone number
            string phone = Console.ReadLine();

            while(!Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))// epression for phone number set to false
             {
                Console.WriteLine("Not a vaild phone number");//error message

                phone = Console.ReadLine();
            }


            return phone;
        }
        

       public static string dateVal()//function for date 
        {
            Console.WriteLine("Enter a date number ");//input for date
            string date = Console.ReadLine();

            while(!Regex.IsMatch(date, @"^\d{1,2}\/\d{1,2}\/\d{4}$"))//epresstion for date set to false
            {

                Console.WriteLine("Not a vaild date");//error message
                Console.ReadLine();
                date = Console.ReadLine();
            }


            return date;
        }
        
    
        public static string htmlValidation()//function for html 
        {
            Console.WriteLine("Enter a HTML string");//input for html
            string html = Console.ReadLine();

            while(!Regex.IsMatch(html,@"</?\w+((\s+\w+(\s*=\s*(?:""[^""]*""|'[^']*'|[^'"">\s]+))?)+\s*|\s*)/?>"))//expression for html set to false
            {

                Console.WriteLine("Sorry this is not a valid expression");//error message
                Console.ReadLine();
                html = Console.ReadLine();//
            }

            return html;

        }


    }
}
