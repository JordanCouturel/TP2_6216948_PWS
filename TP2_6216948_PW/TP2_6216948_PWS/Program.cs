using Humanizer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Data;
using System.Text;
using TP2_6216948_PWS.Data;
using TP2_6216948_PWS.DbInitialiser;
using TP2_6216948_PWS.Models;
using TP2_6216948_PWS.Services;

var builder = WebApplication.CreateBuilder(args);





// Add services to the container.
builder.Services.AddDbContext<TP2DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TP2_6216948_BD") ?? throw new InvalidOperationException("Connection string 'TP2_6216948_BD' not found."))
    .UseLazyLoadingProxies());
builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<TP2DbContext>();


// Adding Authentication  
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer  
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:ValidAudience"],
                    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
                };
            });


builder.Services.AddScoped<IAuthService,AuthService>();
builder.Services.AddScoped<IdBInitialiser, DbInitialiser>();




builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 5;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
});





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
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TP2_6216948_BD"));
}


app.UseCors("Allow all");

app.UseHttpsRedirection();

app.UseAuthentication();
void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IdBInitialiser>();
        dbInitializer.Initialize();

    }
}

SeedDatabase();
app.UseAuthorization();

app.MapControllers();

app.Run();