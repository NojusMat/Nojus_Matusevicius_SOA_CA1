using Nojus_Matusevicius_SOA_CA1.Components;
using Nojus_Matusevicius_SOA_CA1.Service;

// 
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<SearchService>();

// Add other services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Ball dont lie api
builder.Services.AddHttpClient("BallDontLieClient", client =>
{
    client.BaseAddress = new Uri("https://api.balldontlie.io/v1/");
    client.DefaultRequestHeaders.Add("Authorization", "cbc67172-1d75-48a9-8780-a47762cd8e76");
});

// Odds API
builder.Services.AddHttpClient("OddsApiClient", client =>
{
    client.BaseAddress = new Uri("https://api.the-odds-api.com/v4/");
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
