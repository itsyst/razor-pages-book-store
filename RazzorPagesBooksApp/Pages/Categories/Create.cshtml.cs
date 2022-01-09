using Domain;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazzorPagesBooksApp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category  Category { get; set; }

        public void OnGet()
        {

        }
    }
}
