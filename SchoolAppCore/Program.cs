using Microsoft.EntityFrameworkCore;
using SchoolAppCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Register SchoolContext with connection string
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDBConnectionString")));


builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
