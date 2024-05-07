namespace Services.ActorService.Types;

[QueryType]
public static class Query
{
    public static Actor GetActor()
        => new Actor("Tom Cruise", new DateTime(1962, 7, 3));
}

public record Actor(string Name, DateTime DateOfBirth);
