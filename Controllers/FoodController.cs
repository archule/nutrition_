using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using nutrition.Models;

namespace nutrition.Controllers;

[ApiController]
public class FoodController : Controller
{
    [Route("Food")]
    [HttpGet]
    public List<Food> Get()
    {
        return Repository.responses;
    }

    [Route("Food/Form")]
    [HttpGet]
    public ViewResult Form()
    {
        return View("FoodForm");
                
    }

    [Route("Food/Form")]
    [HttpPost]
    public ViewResult Add([FromForm] Food food)
    {

        if (ModelState.IsValid)
        {
            Console.WriteLine("State was valid");
            Repository.AddResponse(food);
            return View("Thanks", food);
        }
        else
        {
            Console.WriteLine("State was NOT valid");
            return View("FoodForm");
        }

        

       
    }

    /*
    [Route("Food/Thanks")]
    [HttpPost]
    public ViewResult Thanks()
    {
        if(ModelState.IsValid)
        {
            return View("Thanks");
        } else
        {
            return View("FoodForm");
        }
                
    }*/

    [Route("Food/ListResponses")]
    [HttpGet]
    public ViewResult ListResponses()
    {
        return View(Repository.Responses.Where(r => r.calories >= 500));
    }



}
