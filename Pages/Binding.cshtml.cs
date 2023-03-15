using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Prelab5.Pages
{
    public class BindingModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public bool IsSubmitted { get; set; }

        public void OnGet()
        {
            IsSubmitted = false;
        }

        public void OnPost()
        {
            IsSubmitted = true;
        }
    }
}
