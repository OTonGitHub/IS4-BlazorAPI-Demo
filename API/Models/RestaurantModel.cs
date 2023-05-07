namespace API.Models;

public class RestaurantModel { // Data Transfer Object / ViewModel / Model - DB <--> App
    public int Id {get; set;}
    public string Name { get; set; }
    public string Location { get; set; }
    public string Rating { get; set; }
}