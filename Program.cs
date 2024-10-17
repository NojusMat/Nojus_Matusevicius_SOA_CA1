using Nojus_Matusevicius_SOA_CA1.Components;
using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Ball dont lie api.
builder.Services.AddHttpClient("BallDontLieClient",client =>
{
    client.BaseAddress = new Uri("https://api.balldontlie.io/v1/");
    client.DefaultRequestHeaders.Add("Authorization", "cbc67172-1d75-48a9-8780-a47762cd8e76");
});

// Odds API
builder.Services.AddHttpClient("OddsApiClient", client =>
{
client.BaseAddress = new Uri("https://api.the-odds-api.com/v4/");
    client.DefaultRequestHeaders.Add("Authorization", "990cde0352439446105fdb349bb3e5b0");
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
