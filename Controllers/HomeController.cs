using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using nutrition.Models;

namespace nutrition.Controllers;

public class HomeController : Controller
{
    /* An action called index 
      Automatically the action because of the template configurations
    
      endpoints:
      /Home
      /
      /Home/Index
    */

    /* this object type requests the rendering of a view 
     
       knows View() --> Views/[Controller]/Index
                        Views/Shared
    */
    public ViewResult Index()
    {
        return View();
    }

}
