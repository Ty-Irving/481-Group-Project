using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using CookingInstructor.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<SearchMode>();
builder.Services.AddSingleton<YourIngredients>();
builder.Services.AddSingleton<CommonIngredients>();
builder.Services.AddScoped<SessionFavourites>();
builder.Services.AddScoped<FilterData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
