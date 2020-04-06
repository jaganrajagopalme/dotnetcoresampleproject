using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorPageMVCSampleProject.Model;

namespace RazorPageMVCSampleProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Appcontextdb _db;

        public IndexModel(ILogger<IndexModel> logger,Appcontextdb db)
        {
            _logger = logger;
            _db = db;
        }
        public IEnumerable<Books> Mydata { get; set; }

        public async Task OnGet()
        {

            var _book = await _db.Books.ToListAsync();
            Mydata = _db.Books.ToList();
            
        }
    }
}
