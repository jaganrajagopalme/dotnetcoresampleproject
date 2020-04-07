using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageMVCSampleProject.Model;

namespace RazorPageMVCSampleProject.Pages
{
    public class EditModel : PageModel
    {
        private readonly Appcontextdb _db;
        public  EditModel(Appcontextdb db)
            {
            _db = db;
            }
        [BindProperty]
        public Books book { get; set; }
        public async Task OnGet(int Id)
        {
             book = await _db.Books.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
             var BookData=   await _db.Books.FindAsync(book.BookId);
                BookData.BookName = book.BookName;
                BookData.AuthorName = book.AuthorName;
                BookData.ISBN = book.ISBN;                
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}