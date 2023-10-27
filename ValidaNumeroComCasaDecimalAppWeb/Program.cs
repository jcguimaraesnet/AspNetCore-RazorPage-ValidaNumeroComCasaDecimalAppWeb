using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ValidaNumeroComCasaDecimalAppWeb.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ValidaNumeroComCasaDecimalAppWebContext>(options =>
    options.UseInMemoryDatabase("test")
    //options.UseSqlServer(builder.Configuration.GetConnectionString("ValidaNumeroComCasaDecimalAppWebContext") ?? throw new InvalidOperationException("Connection string 'ValidaNumeroComCasaDecimalAppWebContext' not found."))
);

var app = builder.Build();

//solução 2 - não resolve input na UI com separador decimal com virgula (com ponto, formato americano)
app.UseRequestLocalization(new RequestLocalizationOptions
{
    SupportedCultures = new[] { new CultureInfo("en-US") },
});


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

app.MapRazorPages();

app.Run();
