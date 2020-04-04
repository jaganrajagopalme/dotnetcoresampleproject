using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreSampleProject.Models
{
    public class Computers
    {
        [Key]
        public int serialNo { get; set; }

        [Display(Name ="Computer Name"),DataType(DataType.Text),Required(ErrorMessage ="Computer Name is requried")]
        public string ComputerName { get; set; }

        [Display(Name = "Computer Type"), DataType(DataType.Text), Required(ErrorMessage = "Computer Type is requried")]
        public string CategoryType { get; set; }

        [Display(Name = "Instance Type"), DataType(DataType.Text), Required(ErrorMessage = "Intance Type is requried")]
        public string  InstanceType { get; set; }

        [Display(Name = "Operating System"), DataType(DataType.Text)]
        public string OsName { get; set; }

        [DataType(DataType.Currency)]
        public float price { get; set; }
    }
}
