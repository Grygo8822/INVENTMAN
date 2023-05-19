using Blazored.Toast;
using INVENTMAN.App.Data;
using INVENTMAN.DataRepository.InMemory;
using INVENTMAN.UseCases.Equipment;
using INVENTMAN.UseCases.Equipment.Interfaces;
using INVENTMAN.UseCases.Inventory;
using INVENTMAN.UseCases.Inventory.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Docker");
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();
builder.Services.AddTransient<IEquipmentSearchUseCase, EquipmentSearchUseCase>();
builder.Services.AddTransient<IEquipmentAddUseCase, EquipmentAddUseCase>();
builder.Services.AddTransient<IEquipmentGetItemByIdUseCase, EquipmentGetItemByIdUseCase>();
builder.Services.AddTransient<IEquipmentEditUseCase, EquipmentEditUseCase>();




builder.Services.AddDbContext<AccountDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => 
{
    options.SignIn.RequireConfirmedEmail = false;
}).AddEntityFrameworkStores<AccountDbContext>();


builder.Services.AddBlazoredToast();

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
app.UseAuthorization();
app.UseAuthentication();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
