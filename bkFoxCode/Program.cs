//using bkFoxCode.BL;
//using boxCode.DAL;
using foxCode.BL;
using foxCode.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

#region Default

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion


#region Database

builder.Services.AddDbContext<foxCodeContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("FoxCodeDB")));

#endregion


#region InjectionForRepo
builder.Services.AddScoped<ICategoriesRepo, CategoriesRepo>();
builder.Services.AddScoped<IProductsRepo, ProductsRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion

#region InjectionForMangers
builder.Services.AddScoped<ICategoriesMangers, CategoriesMangers>();
#endregion



var app = builder.Build();


#region Middlewares
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
#endregion

app.Run();
