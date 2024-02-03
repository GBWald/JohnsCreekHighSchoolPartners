using JohnsCreekHighSchoolPartners.Application.Interfaces;
using JohnsCreekHighSchoolPartners.Components;
using JohnsCreekHighSchoolPartners.Infrastructure.Context;
using JohnsCreekHighSchoolPartners.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<JohnsCreekHighSchoolPartnersDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("JohnsCreekHighSchoolPartnersConnection"));
});

builder.Services.AddScoped<IPartnerRepository, PartnerRepository>();

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
