using Microsoft.EntityFrameworkCore;
using TP2_6216948_PWS.Data;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddDbContext<TP2DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TP2DbContext") ?? throw new InvalidOperationException("Connection string 'TP2DbContext' not found."))
    .UseLazyLoadingProxies());



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("Allow all", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Allow all");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();