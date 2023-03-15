using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Prelab5.Models;

namespace Prelab5.Pages;

public class DisplayPersonModel : PageModel
{
    public Person Person { get; set; }

    public void OnGet(string name, int birthyear)
    {
        Person = new Person
        {
            Name = name,
            BirthYear = birthyear
        };
    }

    
}
