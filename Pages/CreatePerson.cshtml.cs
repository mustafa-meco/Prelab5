using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prelab5.Models;

namespace Prelab5.Pages
{
    public class CreatePersonModel : PageModel
    {
        [BindProperty]
        public Person person { get; set; }

        public void OnGet(string name, int birthYear)
        {
            person = new Person { Name = name, BirthYear = birthYear };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            return RedirectToPage("/DisplayPerson", new { name = person.Name, birthyear = person.BirthYear });
        }
    }
}
