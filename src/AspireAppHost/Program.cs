using HotChocolate.Fusion.Aspire;

var builder = DistributedApplication.CreateBuilder(args);

var actorService = builder.AddProject<Projects.Services_ActorService>("actorService");
var bookService = builder.AddProject<Projects.Services_BookService>("bookService");
var weatherService = builder.AddProject<Projects.Services_WeatherService>("weatherService");

var gateway = builder.AddFusionGateway<Projects.Services_GraphQLGateway>("gateway")
        .WithOptions(new FusionCompositionOptions
        {
            EnableGlobalObjectIdentification = true
        })
        .WithSubgraph(actorService)
        .WithSubgraph(bookService)
        .WithSubgraph(weatherService);

builder.Build().Compose().Run();
