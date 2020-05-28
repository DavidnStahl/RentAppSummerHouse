using MailKit.Net.Smtp;
using rentapp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace rentapp.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(EmailViewModel model)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();
            var client = new System.Net.Mail.SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new System.Net.NetworkCredential(configuration["username"], configuration["password"]),
                EnableSsl = true
            };
            var content = CreateMail(model);
            client.Send("MoneyLaunderingApp@app.se", "rogerstahl@gmail.com", "report", content);
            Console.WriteLine("Sent");
        }
        private string CreateMail(EmailViewModel model)
        {
          var message = new MailMessage();
          message.IsBodyHtml = false;        
           return message.Body = $"Name: {model.Name} {Environment.NewLine} Email: {model.Email} {Environment.NewLine} Question: {Environment.NewLine} {model.Question}";
        }

    }
}
