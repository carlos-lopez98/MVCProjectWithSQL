using Microsoft.AspNetCore.Mvc;
using MVCProjectApp.Data;
using MVCProjectApp.Models;
using MVCProjectApp.Models.Domain;

namespace MVCProjectApp.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly MVCDemoDbContext mVCDemoDbContext;

        public EmployeeController(MVCDemoDbContext mVCDemoDbContext)
        {
            this.mVCDemoDbContext = mVCDemoDbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeViewModel addEmployeeRequest)
        {

            /*
             Notice how this is an object initializer -- **NOT IN JAVA**
             */
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Department = addEmployeeRequest.Department,
                DateOfBirth = addEmployeeRequest.DateOfBirth
            };

            return View(employee);
        }
    }
}
