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

            EmailService email = new GmailService(true, false, true, "Yahoo", "pop@gmail.com", "Привет, я из компании DeliveryUnd", "ya@gmail.com");
            EmailService email1 = new GmailService(true, false, false, "Gmail", "DOP@gmail.com", "Когда деньги вернешь", "ya@gmail.com");
            email.SendEmail("pop@gmail.com", "popa@gmail.com");
            email.ReceiveEmail();

            Console.WriteLine(email);

            GmailService email2 = new GmailService(true, false, true, "Gmail", "pop@gmail.com", "Сегодня на пары", "ya@gmail.com");
            Console.WriteLine(email2);

            Console.WriteLine("-----------------------------------------------------------");
            Emails array = new Emails();

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