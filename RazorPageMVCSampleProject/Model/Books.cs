using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMVCSampleProject.Model
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [DataType(DataType.Text),Display(Name ="Book Name"),Required(ErrorMessage ="The BookName is required")]
        public string BookName { get; set; }

        [DataType(DataType.Text)]
        public string AuthorName { get; set; }

        [DataType(DataType.Text)]
        public string ISBN { get; set; }
    }
}
