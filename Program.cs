// See https://aka.ms/new-console-template for more information
using MailKit.Net.Smtp;
using MimeKit;

var mailMessage = new MimeMessage();

mailMessage.From.Add(new MailboxAddress("Fernando Lerma", "flerma@holati.mx"));

mailMessage.To.Add(new MailboxAddress("Ernesto", "dieguez8@gmail.com"));

mailMessage.Subject = "subject";

mailMessage.Body = new TextPart("plain")

{

    Text = "Hello"

};

using (var smtpClient = new SmtpClient())

{

    smtpClient.Connect("mail.holati.mx", 465, true);

    smtpClient.Authenticate("flerma@holati.mx", "zR}_q8_][FtJd6LS_");

    smtpClient.Send(mailMessage);

    smtpClient.Disconnect(true);

}

Console.WriteLine("Hello, World!");

