using Refit;
using TestApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRefitClient<ISuggestionApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.mapbox.com"));
builder.Services.AddHostedService<TimedHostedService>();

var app = builder.Build();

app.MapGet("/{text}", (HttpContext context, ISuggestionApi suggestionApi) => suggestionApi.GetSuggestions(context.Request.RouteValues["text"] as string));

app.Run();