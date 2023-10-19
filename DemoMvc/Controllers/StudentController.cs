using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

public class StudentController  :   Controller

{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string StudentID, string FullName)
    {
        string strResult = "Hello " + StudentID + "-" + FullName;
        ViewBag.xcv = strResult;
        return View();
    }
}