using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreSampleProject.Interface;
using AspnetCoreSampleProject.Models;
using AspnetCoreSampleProject.Mock;

namespace AspnetCoreSampleProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IComputerRepo _computerInstance;
        private readonly AppcontextDb _dbcontext;
        public HomeController(IComputerRepo _icomp, AppcontextDb _appData)
        {
            _computerInstance = _icomp;
            _dbcontext = _appData;
        }

        public IActionResult Index()
        {
            var data = _computerInstance.ListComputers();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePost(Computers _computers)
        {
            _dbcontext.Computers.Add(_computers);
            var data=  _dbcontext.SaveChanges();
            return View(data);
        }
        public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}