using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<String> Carols { get; set; }
        public IndexModel()
        {
            Carols= new List<string>{
                "Cicha noc",
                "Gdy się Chrystus rodzi",
                "Bóg się rodzi",
                "Lulajże, Jezuniu",
                "Przybieżeli do Betlejem",
                "Wśród nocnej ciszy",
                "Jezus malusieńki",
                "Wesoła nowina",
                "Lulajże, Jezuniu (kołysanka)",
                "Hej, w dzień narodzenia"
            };
        }
        public void OnGet()
        {
        }
    }
}
