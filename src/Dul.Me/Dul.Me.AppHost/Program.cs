var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Dul_Me_ApiService>("apiservice");

builder.AddProject<Projects.Dul_Me_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
