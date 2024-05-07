var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddHttpClient("Fusion");

builder.Services
    .AddFusionGatewayServer()
    .ConfigureFromFile(
        gatewayConfigurationFile: "./gateway.fgp",
        watchFileForUpdates: true);

var app = builder.Build();

app.MapGraphQL();
app.MapDefaultEndpoints();

app.RunWithGraphQLCommands(args);
