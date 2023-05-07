using Microsoft.AspNetCore.Mvc;
using API.Services;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]s")]
public class RestaurantController : ControllerBase {
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantServiceI) {
        this._restaurantService = restaurantServiceI;
    }

    [HttpGet]
    // [Route("ListAll")]
    public async Task<IActionResult> ListAll(){
        var restaurants = await _restaurantService.List();
        return Ok(restaurants);
    }
}