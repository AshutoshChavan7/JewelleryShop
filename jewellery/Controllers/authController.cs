using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using jewellery.Models;

namespace jewellery.Controllers;

public class authController : Controller
{
    private readonly ILogger<authController> _logger;

    public authController(ILogger<authController> logger)
    {
        _logger = logger;
      
    }


 public IActionResult Login()
    {
        return View();
    }


 public IActionResult Validate(string emailid,string password)
    {
        if(emailid=="ashu@gmail.com" && password=="1234"){
            return Redirect("/Home/welcome");
        }

        else

        return Redirect("/auth/login");
    }


}