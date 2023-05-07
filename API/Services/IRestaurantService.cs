using API.Models;

namespace API.Services;

public interface IRestaurantService {
    Task<List<RestaurantModel>> List();
}