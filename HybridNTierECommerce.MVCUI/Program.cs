using HybridNTierECommerce.BLL.DependencyResolvers;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); //Eger Session kompleks yapılarla calısmak icin Extension metodu ekleme durumuna maruz kalacaksa bu kod projenizin saglıklı calısması icin gerekli...


builder.Services.AddSession(x =>
{
    x.IdleTimeout = TimeSpan.FromDays(1); //Projeyi kişinin bos durma serisi eger 1 günlük bir süre olursa Session otomatik olarak bosa cıksın...
    x.Cookie.HttpOnly = true;
    x.Cookie.IsEssential = true;

});


builder.Services.AddIdentityService();
builder.Services.AddDbContextService();
builder.Services.AddRepositoryServices();
builder.Services.AddManagerServices();






WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Admin",
    pattern:"{area}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Register}/{id?}");

app.Run();
