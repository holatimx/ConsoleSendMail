// See https://aka.ms/new-console-template for more information
using MailKit.Net.Smtp;
using MimeKit;

var mailMessage = new MimeMessage();

mailMessage.From.Add(new MailboxAddress("from name", "from email"));

mailMessage.To.Add(new MailboxAddress("to name", "to email"));

mailMessage.Subject = "subject";

mailMessage.Body = new TextPart("plain")

{

    Text = "Hello"

};

using (var smtpClient = new SmtpClient())

{

    smtpClient.Connect("smtp.gmail.com", 587, true);

    smtpClient.Authenticate("user", "password");

    smtpClient.Send(mailMessage);

    smtpClient.Disconnect(true);

}

Console.WriteLine("Hello, World!");

