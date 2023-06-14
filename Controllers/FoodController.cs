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

    [Route("Food/Add")]
    [HttpPost]
    public ViewResult Add([FromForm] Food food)
    {

        Repository.AddResponse(food);

        return View("Thanks", food);
    }

    [Route("Food/Thanks")]
    [HttpPost]
    public ViewResult Thanks()
    {
        return View("Thanks");
    }



}
