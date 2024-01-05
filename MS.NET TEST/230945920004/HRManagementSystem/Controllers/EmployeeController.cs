using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginMVC.Models;
using BOL;
using DAL;

namespace LoginMVC.Controllers;
public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult Display()
    {
        List<Employee> elst = DBManager.DisplayAll();
        foreach(Employee e in elst)
        {
            Console.WriteLine(e.Id);
        }
        ViewData["Employees"]=elst;
        return View();
    }







    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Insert(int id, string name, string email, string contactnumber)
    {
        Employee e = new Employee(id, name, email, contactnumber);
        DBManager.InsertEmployee(e);
        return View();
    }


    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        DBManager.DeleteEmployee(id);
        return View();
    }


    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Update(int id, string name, string email, string contactnumber)
    {
        Employee e = new Employee(id, name, email, contactnumber);
        DBManager.UpdateEmployee(e);
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}