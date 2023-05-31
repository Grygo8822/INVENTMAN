using Blazored.Toast;
using INVENTMAN.App.Data;
using INVENTMAN.DataRepository.Postgresql;
using INVENTMAN.UseCases.Employees;
using INVENTMAN.UseCases.Employees.Interfaces;
using INVENTMAN.UseCases.Equipment;
using INVENTMAN.UseCases.Equipment.Interfaces;
using INVENTMAN.UseCases.Manufacturers;
using INVENTMAN.UseCases.Manufacturers.Interfaces;
using INVENTMAN.UseCases.Vendors;
using INVENTMAN.UseCases.Vendors.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Docker");


//Obs³uga uwierzytelniania i autoryzacji za pomoc¹ ASP.NET Core Identity
builder.Services.AddDbContext<AccountDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AccountDbContext>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("UserAdmin", policy => policy.RequireAuthenticatedUser()
    .RequireClaim("Users", "Adminstrate"));
    options.AddPolicy("ITAdminEdit", policy => policy.RequireClaim("Items", "Edit"));
    options.AddPolicy("ITAdminCreate", policy => policy.RequireClaim("Items", "Create"));
    options.AddPolicy("AllUsers", policy => policy.RequireClaim("All", "Read"));
    options.AddPolicy("HRAdminCreate", policy => policy.RequireClaim("Employees", "Edit"));
    options.AddPolicy("HRAdminEdit", policy => policy.RequireClaim("Employees", "Create"));

});



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Obs³uga przechowania danych za pomoc¹ EF Core
builder.Services.AddDbContextFactory<InventmanContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddScoped<IManufacturersRepository, ManufacturerEFCoreRepository>();
builder.Services.AddScoped<IVendorRepository, VendorEFCoreRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeEFCoreRepository>();

//Equipment Use Cases

builder.Services.AddScoped<IEquipmentRepository, EquipmentEFCoreRepository>();
builder.Services.AddTransient<IEquipmentSearchAdvancedUseCase, EquipmentSearchAdvancedUseCase>();

builder.Services.AddTransient<IEquipmentSearchUseCase, EquipmentSearchUseCase>();
builder.Services.AddTransient<IEquipmentAddUseCase, EquipmentAddUseCase>();
builder.Services.AddTransient<IEquipmentGetItemByIdUseCase, EquipmentGetItemByIdUseCase>();
builder.Services.AddTransient<IEquipmentEditUseCase, EquipmentEditUseCase>();

//Vendor Use Cases
builder.Services.AddTransient<IAddVendorUseCase, AddVendorUseCase>();
builder.Services.AddTransient<ISearchVendorByNameUseCase, SearchVendorByNameUseCase>();

//Manufcaturer Use Cases
builder.Services.AddTransient<IAddManufacturerUseCase, AddManufacturerUseCase>();
builder.Services.AddTransient<ISearchManufacturersByNameUseCase, SearchManufacturersByNameUseCase>();

//Employee Use Cases
builder.Services.AddTransient<IAddEmployeeUseCase, AddEmployeeUseCase>();
builder.Services.AddTransient<ISearchEmployeeByNameUseCase, SearchEmployeeByNameUseCase>();
builder.Services.AddTransient<IGetEmployeeByIdUseCase, GetEmployeeByIdUseCase>();
builder.Services.AddTransient<IGetEmployeeByIdWithEqipmentUseCase, GetEmployeeByIdWithEqipmentUseCase>();

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
