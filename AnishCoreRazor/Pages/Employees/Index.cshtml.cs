using AnishCoreRazor.Data;
using AnishCoreRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnishCoreRazor.Pages.Employees
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public List<Employee>EmployeeList { get; set; }

        public IndexModel(ApplicationDbContext Db)
        {
            _db = Db;
        }
        public void OnGet()
        {
            EmployeeList = _db.Employees.ToList();
        }
    }
}
