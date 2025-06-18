using Microsoft.EntityFrameworkCore;
using tiklaa_blazor_game.Components;
using TiklaaGame.Data; // TiklaaDbContext için gerekli

var builder = WebApplication.CreateBuilder(args);

// 🔹 EF Core: DbContext ve bağlantı cümlesi
builder.Services.AddDbContext<TiklaaDbContext>(options =>
    options.UseSqlServer("Server=.;Database=TiklaaDb;Trusted_Connection=True;TrustServerCertificate=True;"));

// Blazor bileşenlerini ekle
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Pipeline yapılandırması
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
