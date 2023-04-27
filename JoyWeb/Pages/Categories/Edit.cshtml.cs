using JoyWeb.Data;
using JoyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoyWeb.Pages.Categories
{
    public class EditCategory : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public EditCategory(ApplicationDbContext db)
        {
            _db = db;
        }
 
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString()) {
                ModelState.AddModelError("Category.Name","The Display Order cannot match the name");
            }
            if (ModelState.IsValid) 
            { 
                  _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category Updated Successfuly";
                return RedirectToPage("Index");
            }

            return Page();  
        }
    }
}
