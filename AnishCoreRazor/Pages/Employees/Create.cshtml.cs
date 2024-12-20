using AnishCoreRazor.Data;
using AnishCoreRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnishCoreRazor.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public  Employee Employee { get; set; }

        public CreateModel(ApplicationDbContext Db)
        {
            _db = Db;
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (Employee.Name == Employee.phone.ToString())
            {
                ModelState.AddModelError("name", "The phone cannot same with name");
            }
            if (ModelState.IsValid && Employee.Emp_Id == 0)
            {
                _db.Employees.Add(Employee);
                _db.SaveChanges();
                TempData["sucess"] = "Employee sucessfully added";
            }
            else
            {
                _db.Employees.Update(Employee);
                _db.SaveChanges();
                TempData["sucess"] = "Employee sucessfully Updated";
            }
            return RedirectToPage("/Employees/Index");
        }
    }
}
