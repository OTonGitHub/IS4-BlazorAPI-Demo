using API.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorClient.Services;
using IdentityModel.Client;

namespace BlazorClient.Pages;

public partial class Restaurants
{
    private List<RestaurantModel> restaurants = new();
    [Inject] private HttpClient HttpClient { get; set; }
    [Inject] private IConfiguration Config { get; set; }
    [Inject] private ITokenService TokenService { get; set; }


    protected override async Task OnInitializedAsync()
    {
        var tokenResponse = await TokenService.GetToken("RestaurantAPI.read");
        HttpClient.SetBearerToken(tokenResponse.AccessToken);

        var result = await HttpClient.GetAsync(Config["apiUrl"] + "/api/restaurants");

        if (result.IsSuccessStatusCode)
        {
            restaurants = await result.Content.ReadFromJsonAsync<List<RestaurantModel>>();
        }
    }
}