using Domain;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Application.Interfaces;

namespace RazzorPagesBooksApp.Pages.Categories
{
#pragma warning disable CS1998
    public class IndexModel : PageModel
    {
         private readonly IUnitOfWork<Category> _category;

        public IndexModel(IUnitOfWork<Category> category)
        {
            _category = category;
        }

        public IList<Category> Category { get; set; }


        public Task OnGet()
        {
            Category = _category.Entity.GetAll().ToList();
        }
        
    }
}
