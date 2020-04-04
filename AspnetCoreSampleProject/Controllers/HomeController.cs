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
            var data = _dbcontext.Computers.ToList();
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
            if (ModelState.IsValid)
            { 
            _dbcontext.Computers.Add(_computers);
            var data = _dbcontext.SaveChanges();
                return RedirectToAction (nameof(Index));
            }
            else
            {
                return View();
            }
           
        }
        
        public IActionResult Details(int id)
        {
            var data = _dbcontext.Computers.Find(id);
            return View(data);
        }

        public IActionResult Edit(int? id)
        {
            
            var data = _dbcontext.Computers.Find(id);
            if (data==null)
            {
                return NotFound();
            }
            return View(data);
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditComputer(Computers computer)
        {
            if (computer == null)
            {
                return NotFound();
            }
            else
            {
                _dbcontext.Update(computer);
                _dbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost]
        [ActionName("DeletePost")]
        public IActionResult Delete(int id)
        {
           var computer=  _dbcontext.Computers.Find(id);
            _dbcontext.Computers.Remove(computer);
            _dbcontext.SaveChanges();

            return View(nameof(Index));
        }
    }
}