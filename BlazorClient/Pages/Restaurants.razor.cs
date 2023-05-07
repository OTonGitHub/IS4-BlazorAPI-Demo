using API.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorClient.Pages;

public partial class Restaurants {
    // public Restaurants()
    // {}
    private List<RestaurantModel> restaurants = new();
    [Inject] private HttpClient HttpClient {get; set;}
    [Inject] private IConfiguration config {get; set;}

    protected override async Task OnInitializedAsync() {
        var result = await HttpClient.GetAsync(config["ApiUrl"] + "/api/restaurants");

        if(result.IsSuccessStatusCode) {
            restaurants = await result.Content.ReadFromJsonAsync<List<RestaurantModel>>();
        }
    }
}
