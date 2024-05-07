namespace Services.WeatherService.Types;

[QueryType]
public static class Query
{
    public static Weather GetWeather()
        => new Weather("Seattle", 75);
}

public record Weather(string City, int Degrees);
