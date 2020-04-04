using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreSampleProject.Models;

namespace AspnetCoreSampleProject.Interface
{
    public interface IComputerRepo
    {
        //IEnumerable<Computers> ListComputer { get; set; }
        // Computers GetComputers(int Id);

        List<Computers> ListComputers();
    }
}
