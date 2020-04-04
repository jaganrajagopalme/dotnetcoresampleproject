using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreSampleProject.Models
{
    public class InstanceCategories
    {
       
        public List<InstanceCategories> InstanceCollection { get; set; }
        public string InstanceName { get; set; }
       
       
    }

    public class ComputerCategories
    {

        public List<ComputerCategories> CategoriesName { get; set; }
    }
}
