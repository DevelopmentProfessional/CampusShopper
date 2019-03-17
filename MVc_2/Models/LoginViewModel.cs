using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVc_2.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Permissions { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
    }
}