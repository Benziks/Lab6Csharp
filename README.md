# Lab6

  Вариант 3
  
    Создайте интерфейс `IEmailSender` с методами `void SendEmail(string recipient, string message)` и `void ReceiveEmail()`. 
    
    Реализуйте этот интерфейс в абстрактном классе `EmailService` с readonly полем `string smtpServer` и конструктором с init спецификатором.
    
    Создайте класс `GmailService`, который наследуется от `EmailService` и реализует интерфейс `IEmailSender`.
