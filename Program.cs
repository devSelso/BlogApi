using BlogApi.Data; // Adicione este using
using Microsoft.EntityFrameworkCore; // Adicione este using

var builder = WebApplication.CreateBuilder(args);

// 1. Pega a connection string do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. Adiciona o DbContext ao contêiner de serviços e o configura para usar o SQLite
builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlite(connectionString));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();