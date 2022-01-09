using Domain;
 using Microsoft.AspNetCore.Mvc.RazorPages;
using Infrastructure.Repository;
using Application.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace RazzorPagesBooksApp.Pages.Categories
{
#pragma warning disable CS8618
#pragma warning disable CS8604
#pragma warning disable CS1998
    public class IndexModel : PageModel
    {
         private readonly IUnitOfWork<Category> _category;

        public IndexModel(IUnitOfWork<Category> category)
        {
            _category = category;
        }

        public IList<Category> Category { get; set; }


        public async Task OnGetAsync()
        {
            Category = _category.Entity.GetAll().ToList();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
