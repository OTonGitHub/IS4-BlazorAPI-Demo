using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using API.Models;

namespace BlazorClient.Pages;


public partial class Restaurants {
    // public Restaurants()
    // {}
    private List<RestaurantModel> Restaurants = new();
    [inject] private HttpClient HttpClient {get; set;}
    [inject] private IConfiguration config {get; set;}

    protected override async Task OnInitializedAsync() {
        var result = await HttpClient.GetAsync(config["ApiUrl"] + "/api/restaurants");

        if(result.IsSuccessStatusCode) {
            Restaurants = await result.Content.ReadFromJsonAsync<List<RestaurantModel>>();
        }
    }
}
