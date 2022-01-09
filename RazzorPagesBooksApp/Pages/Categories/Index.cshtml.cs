using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazzorPagesBooksApp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork<Category> _category;

        public IndexModel(IUnitOfWork<Category> category)
        {
            _category = category;
        }

        public IList<Category> Category { get; set; }


        public void OnGet()
        {
            Category = _category.Entity.GetAll().ToList();
        }
    }
}
