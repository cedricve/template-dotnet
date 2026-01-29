using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http.Json;

namespace WebApp.Tests;

public class WeatherForecastControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private readonly HttpClient _client;

    public WeatherForecastControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _client = _factory.CreateClient();
    }

    [Fact]
    public async Task GetWeatherForecast_ReturnsSuccessStatusCode()
    {
        // Act
        var response = await _client.GetAsync("/WeatherForecast");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task GetWeatherForecast_ReturnsFiveForecasts()
    {
        // Act
        var forecasts = await _client.GetFromJsonAsync<WeatherForecast[]>("/WeatherForecast");

        // Assert
        Assert.NotNull(forecasts);
        Assert.Equal(5, forecasts.Length);
    }
}
