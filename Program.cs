﻿using System;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User\r\nRegistration");

            RegistrationForm form = new RegistrationForm();
            form.Form();
        }
    }
}
