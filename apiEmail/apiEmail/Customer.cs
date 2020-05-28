using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiEmail
{
    public class Customer
    {
        public string Contact_Name { get; set; }
        public string Contact_Email { get; set; }
        public string Contact_Question { get; set; }
    }
}
