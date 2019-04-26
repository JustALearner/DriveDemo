using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drive.WebApp.Models
{
    public class DriveSchool
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ActionUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
        public string[] Type { get; set; }
        public string Money { get; set; }
        public string License { get; set; }
    }
}