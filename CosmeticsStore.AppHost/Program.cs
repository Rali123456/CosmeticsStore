var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.CosmeticsStore_ApiService>("apiservice");

builder.AddProject<Projects.CosmeticsStore_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
