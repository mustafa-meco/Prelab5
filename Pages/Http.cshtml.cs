using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Prelab5.Pages
{
    public class HttpModel : PageModel
    {
        public IActionResult OnGet()
        {
            // Perform actions for GET request
            return Page();
        }

        public IActionResult OnPost()
        {
            // Perform actions for POST request
            return Page();
        }
    }
}
