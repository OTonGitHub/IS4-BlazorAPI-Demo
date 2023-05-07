using Microsoft.AspNetCore.Mvc;
using API.Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController : ControllerBase {
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantServiceI) {
        this._restaurantService = restaurantServiceI;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> List(){
        var restaurants = await _restaurantService.List();
        return Ok(restaurants);
    }
}