using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{

    public class Pattern 
    {
        public static string Name = @"[A-Z]{1}[a-z]{2,}";
        public static string LastName= @"[A-Z]{1}[a-z]{2,}";
    }
    internal class RegistrationForm
    {
        public void Form()
        {
            Regex name = new Regex(Pattern.Name);
            Console.WriteLine("First name starts with Cap and has minimum 3 characters");
           
            bool check = false;
           
            while(!check)
            {
                Console.Write("Enter your name : ");
                string usernasme = Console.ReadLine();
                check = name.IsMatch(usernasme);
                if (check == false)
                {
                    Console.WriteLine("\nplease follow - First name starts with Cap and has minimum 3 characters ");
                }
                else
                { Console.WriteLine("Done"); }

                
            }

            Regex lastname= new Regex(Pattern.LastName);
            Console.WriteLine("Last name starts with Cap and has minimum 3 characters");
            check = false;

            while (!check)
            {
                Console.Write("Enter your last name : ");
                string userLastName= Console.ReadLine();
                check = lastname.IsMatch(userLastName);
                if (check == false)
                {
                    Console.WriteLine("\nplease follow - Last name starts with Cap and has minimum 3 characters ");
                }
                else
                { Console.WriteLine("Done"); }


            }

        }
    }
}
