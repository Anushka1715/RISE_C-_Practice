using Microsoft.AspNetCore.Mvc;
using MVC.NET6_CRUDEntityFramework.Data;
using MVC.NET6_CRUDEntityFramework.Models;
using MVC.NET6_CRUDEntityFramework.Models.Domain;

namespace MVC.NET6_CRUDEntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MVCDemoDbContext mVCDemoDbContext;

        public EmployeeController(MVCDemoDbContext mVCDemoDbContext)
        {
            this.mVCDemoDbContext = mVCDemoDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
           var employees = mVCDemoDbContext.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeViewModel addEmployeeViewModel)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeViewModel.Name,
                Email = addEmployeeViewModel.Email,
                Salary = addEmployeeViewModel.Salary,
                Department = addEmployeeViewModel.Department,
                DateOfBirth = addEmployeeViewModel.DateOfBirth
            };

            mVCDemoDbContext.Employees.Add(employee);
            mVCDemoDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult View(Guid id)
        {
            var employee = mVCDemoDbContext.Employees.FirstOrDefault(x => x.Id == id);

            if(employee != null) 
            {
                var viewModel = new UpdateEmployeeView()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    Salary = employee.Salary,
                    Department = employee.Department,
                    DateOfBirth = employee.DateOfBirth
                };

                return View("View",viewModel);
            }
          
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult View(UpdateEmployeeView updateEmployeeView)
        {
            var employee = mVCDemoDbContext.Employees.Find(updateEmployeeView.Id);

            if(employee != null)
            {
                employee.Name = updateEmployeeView.Name;
                employee.Email = updateEmployeeView.Email;
                employee.Salary = updateEmployeeView.Salary; 
                employee.DateOfBirth = updateEmployeeView.DateOfBirth;
                employee.Department = updateEmployeeView.Department;

                mVCDemoDbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(UpdateEmployeeView model) {
            var employee = mVCDemoDbContext.Employees.Find(model.Id);

            if (employee != null)
            {
                mVCDemoDbContext.Employees.Remove(employee);
                 mVCDemoDbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");

        }
    }
}
