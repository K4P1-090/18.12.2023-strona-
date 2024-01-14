using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MyApp.Namespace
{
    public class Page3Model : PageModel
    {
        [BindProperty]
        public List<string> Zwyczaje { get; set; }

        public Page3Model()
        {
            Zwyczaje = new List<string>
            {
                "Ości z karpia w portfelu",
                "Ubieranie choinki",
                "Sianko pod obrusem",
                "12 potraw wigilijnych",
                "Prezenty pod choinką"
                
            };
        }

        public void OnGet()
        {
        }
    }
}
