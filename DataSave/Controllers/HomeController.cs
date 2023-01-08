using DataSave.Data;
using DataSave.Models;
using DataSave.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataSave.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository user;
        public HomeController(IUserRepository user)
        {
            this.user = user;
        }
        public async Task<IActionResult> Index()
        {
            var data = await user.GetAll();
            return View(data);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var data = await user.GetFindById(id);
            return View(data);
        }
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
         public async Task<IActionResult> Create(User model)
         {
            await  user.Add(model);

            return RedirectToAction("Index");
         }

    }
}