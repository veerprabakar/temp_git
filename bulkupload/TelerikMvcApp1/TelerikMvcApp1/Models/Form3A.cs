using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class Form3A
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string RepNumber { get; set; }

        public string RepName { get; set; }

        public string NRIC { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Passport { get; set; }

        public ICollection<Activity> Activities { get; set; }

        public Form3A()
        {
            Activities = new List<Activity>();
        }
    }
}