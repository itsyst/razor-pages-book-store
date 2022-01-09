using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazzorPagesBooksApp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork<Category> _category;

        public CreateModel(IUnitOfWork<Category> category)
        {
            _category = category;
        }

        public Category  Category { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(Category.Name == Category.Order.ToString())
            {
                ModelState.AddModelError(string.Empty, "The Order cannot much the Name.");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _category.Entity.Insert(Category);
            _category.Save();
            return RedirectToPage("./Index");
        }
    }
}
