using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "fakebsef14@gmail.com";
        public string MailFromAddress = "fakebsef14@gmail.com";
        public bool UseSsl = true;
        public string Username = "fakebsef14@gmail.com";
        public string Password = "secretpassword";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
