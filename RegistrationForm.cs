using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{

//    As a User need to
//enter a valid First
//Name
//- First name starts with Cap and has
//minimum 3 characters
    public class Pattern 
    {
        public static string Name = @"[A-Z]{1}[a-z]{2,}";

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
        }
    }
}
