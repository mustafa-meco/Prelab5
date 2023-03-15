using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Prelab5.Pages
{
    public class ParameterModel : PageModel
    {
        [BindProperty]
        public int? Result { get; set; }


        public void OnPost(int firstNumber, int secondNumber, string operation)
        {
            switch (operation)
            {
                case "add":
                    Result = firstNumber + secondNumber;
                    break;
                case "subtract":
                    Result = firstNumber - secondNumber;
                    break;
                case "multiply":
                    Result = firstNumber * secondNumber;
                    break;
                case "divide":
                    if (secondNumber == 0)
                    {
                        ModelState.AddModelError(string.Empty, "Cannot divide by zero.");
                        Result = null;
                    }
                    else
                    {
                        Result = firstNumber / secondNumber;
                    }
                    break;
                default:
                    Result = null;
                    break;
            }
        }
    }
}
