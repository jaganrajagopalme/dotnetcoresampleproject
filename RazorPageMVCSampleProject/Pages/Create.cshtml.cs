using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageMVCSampleProject.Model;

namespace RazorPageMVCSampleProject.Pages
{
    public class CreateModel : PageModel
    {
        public readonly Appcontextdb _db;
        public CreateModel(Appcontextdb db)
        {
            _db = db;
        }
        [BindProperty]
        public Books book { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Books.AddAsync(book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else

            {
                return Page();
            }
        }

        public async Task<IActionResult> OnEdit()
        {
            return RedirectToPage("Edit");
        }
    }
}