using Anish_core.Data;
using Anish_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anish_core.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
       
        public IActionResult Employee()
        {
            List<Employee> employeelist = _db.Employees
        .Select(emp => new Employee
        {
            Name = emp.Name,
            phone = emp.phone
        })
        .ToList();

            return View(employeelist);
        }

        public IActionResult Create(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return View();
            }
            Employee employeedit = _db.Employees.Find(Id);
            if (employeedit == null)
            {
                return View();
            }
            
            return View(employeedit);
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (obj.Name == obj.phone.ToString())
            {
                ModelState.AddModelError("name", "The phone cannot same with name");
            }
            if (ModelState.IsValid && obj.Emp_Id==0)
            {
                _db.Employees.Add(obj);
                _db.SaveChanges();
                TempData["sucess"] = "Employee sucessfully added";
            }
            else
            {
                _db.Employees.Update(obj);
                _db.SaveChanges();
                TempData["sucess"] = "Employee sucessfully Updated";
            }
            return RedirectToAction("employee");
        }


        //public IActionResult Edit(int? Id)
        //{
        //    if (Id == null || Id == 0)
        //    {
        //        return NotFound();  
        //    }
        //    Employee employeedit=_db.Employees.Find(Id);
        //    if (employeedit == null) {
        //        return NotFound();
        //    }
        //    return View(employeedit);
        //}

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
           
            if (ModelState.IsValid)
            {
                _db.Employees.Update(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("employee");
        }
        [ActionName("Delete")]
        public IActionResult Delete(int? Id)
        {
            Employee? obj = _db.Employees.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Employees.Remove(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("employee");
        }
    }
}
