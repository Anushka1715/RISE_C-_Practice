using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MVC_BusinessLogic.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new BusinessLayer.EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.GetAllEmployees();
            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Employee employee = new Employee();
            employee.Name = formCollection["Name"];
            employee.City = formCollection["City"];
            employee.Address = formCollection["Address"];

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();  
            employeeBusinessLayer.AddEmployee(employee);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int Empid) {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.GetAllEmployees().FirstOrDefault(emp => emp.Empid == Empid);
            return View(employee);

        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if(ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(id);

            return RedirectToAction("Index");
        }

        
    }
}