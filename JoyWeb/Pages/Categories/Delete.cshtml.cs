using JoyWeb.Data;
using JoyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoyWeb.Pages.Categories
{
    public class DeleteCategory : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public DeleteCategory(ApplicationDbContext db)
        {
            _db = db;
        }
 
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {
           
           
                var category =  _db.Category.Find(Category.Id);  
                if (category != null) {
                    _db.Category.Remove(category);
                    await _db.SaveChangesAsync();
                    TempData["success"] = "Category Deleted Successfuly";
                    return RedirectToPage("Index");
                 }
             
           

            return Page();  
        }
    }
}
