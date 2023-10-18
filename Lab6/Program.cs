using Lab6;
using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmailService email = new GmailService(true, false, true, "Yahoo", "pop@gmail.com", "Privet aboba", "ya@gmail.com");
            EmailService email1 = new GmailService(true, false, true, "Yahoo", "DOP@gmail.com", "Privet aboba", "ya@gmail.com");
            email.SendEmail("pop@gmail.com", "popa@gmail.com");
            email.ReceiveEmail();

            Console.WriteLine(email);

            GmailService email2 = new GmailService(true, false, true, "Yahoo", "pop@gmail.com", "Privethh aboba", "ya@gmail.com");
            Console.WriteLine(email2);

            Console.WriteLine("-----------------------------------------------------------");
            EmailArray array = new EmailArray();

            array.AddEmail(email2);
            array.AddEmail(email1);
            array.AddEmail(email);


            foreach (var community in array.EmailService)
            {
                Console.WriteLine(community);
            }
            Console.WriteLine("-----------------------------------------------------------");

            array.DeleteEmail(0);
            foreach (var community in array.EmailService)
            {
                Console.WriteLine(community);
            }
            Console.WriteLine("-----------------------------------------------------------");

            array.EditEmail(email2, 1);
            foreach (var community in array.EmailService)
            {
                Console.WriteLine(community);
            }

            Console.ReadLine();

        }
    }
}