using EmployeeManagement.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.UI.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService employeeService = new EmployeeService();

        // GET: EmployeeController
        public ActionResult Index()
        { 
            //from employee service
            var employeeBLModelList = employeeService.GetAllEmployees(); //vishnu, sayful

            //convert business model "Employee" to view model "EmployeeViewModel"

            List<EmployeeViewModel> viewModelList = new List<EmployeeViewModel>();

            foreach (var employeeBLModel in employeeBLModelList)
            {
                //1st Iteration Vishnu

                EmployeeViewModel viewModel = new EmployeeViewModel();
                viewModel.EmployeeID = employeeBLModel.EmployeeID;
                viewModel.EmployeeName = employeeBLModel.EmployeeName;
                viewModel.Salary = employeeBLModel.Salary;
                viewModelList.Add(viewModel);
            }

            return View(viewModelList);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
