using JoyWeb.Data;
using JoyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoyWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
 
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString()) {
                ModelState.AddModelError("Category.Name","The Display Order cannot match the name");
            }
            if (ModelState.IsValid) 
            { 
                await  _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category Created Successfuly";
                return RedirectToPage("Index");
            }

            return Page();  
        }
    }
}
