using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace MyApp.Namespace
{
    public class Page1Model : PageModel
    {
        public class Gift
        {
            public string Name { get; set; }
            public double Prize { get; set; }
            public string ForWho { get; set; }
        }

        [BindProperty]
        public List<Gift> Gifts { get; set; } = new List<Gift>{
            new Gift{ Name="Klocki Lego", Prize=199.99, ForWho="Jacek"},
            new Gift{ Name="Dysk Zewnętrzny", Prize=349.45, ForWho="Kacper"},
            new Gift{ Name="iPhone 15", Prize=4499, ForWho="Wiktoria"},
            new Gift{ Name="Pluszak Electro Slime", Prize=59.99, ForWho="Emilka"}
        };

        public void OnGet()
        {
        }
    }
}