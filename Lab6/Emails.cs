using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public class Emails
    {
        private EmailService[] _emailService;

        public Emails(params EmailService[] elements)
        {
            if (elements is not null)
            {
                _emailService = elements;
            }
            else
            {
                _emailService = new EmailService[0];
            }
        }

        /// <summary>
        /// Добавление объекта в массив.
        /// </summary>
        /// <param name="emailService">Объект для добавления.</param>
        /// <exception cref="FormatException"></exception>
        public void AddEmail(EmailService emailService)
        {
            if (emailService is null)
            {
                throw new FormatException("Неверно задано письмо");
            }
            else
            {
                Array.Resize(ref _emailService, _emailService.Length + 1);
                _emailService[_emailService.Length - 1] = emailService;
            }
        }

        /// <summary>
        /// Удаление объекта из массива.
        /// </summary>
        /// <param name="emailNumber">Индекс элемента который необходимо удалить.</param>
        public void DeleteEmail(int emailNumber)
        {
            if (emailNumber >= 0 && emailNumber < _emailService.Length)
            {
                Array.Copy(_emailService, emailNumber + 1, _emailService, emailNumber, _emailService.Length - emailNumber - 1);
                Array.Resize(ref _emailService, _emailService.Length - 1);
                Console.WriteLine($"Письмо с номером {emailNumber} успешно удалено.");
            }

        }

        /// <summary>
        /// Обновление элемента массива по индексу, вернет FormatException, если индекс неверно задан
        /// </summary>
        /// <param name="emailService">Новый элемент</param>
        /// <param name="emailNumber">Индекс обновляемого объекта</param>
        /// <exception cref="FormatException"></exception>
        public void EditEmail(EmailService emailService, uint emailNumber)
        {
            if (emailNumber >= 0 && emailNumber < _emailService.Length)
            {
                _emailService[emailNumber] = emailService;
            }
            else
            {
                throw new FormatException("Неверно указан индекс");
            }
        }

        public EmailService[] EmailService => _emailService;

        public override string ToString()
        {
            String result = "";
            foreach (EmailService emailService in _emailService)
            {
                result += emailService + "\n";
            }
            return result;
        }
    }
}