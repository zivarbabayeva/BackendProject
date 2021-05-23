using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectBackend.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test Project", "zivarab@code.edu.az"));
            message.To.Add(new MailboxAddress ("zivar","b.ziva86@gmail.com"));
            message.Subject = "test mail in asp.net core";
            message.Body = new TextPart("plain")
            {
                Text="Hello world mail"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("zivarab@code.edu.az", "visualstudio");
                client.Send(message);
                client.Disconnect(true);
            }
                return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page";
            return View();
        }
   
    }
          
}
