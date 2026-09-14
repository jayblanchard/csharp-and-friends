 using DioramaContinuity.Api;

 var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "In Progress", "Paused", "Model", "Base"
};

app.MapGet("/dioramacontinuity", () =>
{
    var project = new DioramaProject
    {
        Id = 1,
        Name = "Hemisphere Dancer",
        Status = "In Progress"
    };

    return project;
});

//app.MapGet("/", () => "Diorama Continuity API");

app.Run();

