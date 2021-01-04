using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecaptchaWebApp.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string captcha { get; set; }
    }
}
