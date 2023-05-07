using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class RestaurantService : IRestaurantService {
    private readonly AppDbContext _AppDbContext; // just _dbContext?
    public RestaurantService(AppDbContext dbContext){
        this._AppDbContext = dbContext;
    }
    public async Task<List<RestaurantModel>> List(){
        var restaurants = await(
            _AppDbContext.Restaurants.Select( col => 
                new RestaurantModel {
                    Id = col.Id,
                    Name = col.Name,
                    Location = col.Location,
                    Rating = col.Rating
                }
            ).ToListAsync()
        );
        return restaurants;
    }
}