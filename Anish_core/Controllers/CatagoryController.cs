using Anish_core.Data;
using Anish_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anish_core.Controllers
{
    public class CatagoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CatagoryController(ApplicationDbContext db) 
        {
            _db = db;

        } 
        public IActionResult Index()
        {
            List<Catagory> objCatagoryList = _db.Catagories.ToList();
            return View(objCatagoryList);
        }
    }
}
