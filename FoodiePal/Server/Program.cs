using FoodiePal.Server.Database;
using FoodiePal.Server.Extensions;
using FoodiePal.Server.Recipes.Repositories;
using FoodiePal.Server.Users.Application.Services;
using FoodiePal.Server.Users.Infrastructure.Repositories;
using FoodiePal.Shared.Recipes.Repository;
using FoodiePal.Shared.Users.Repository;
using FoodiePal.Shared.Users.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


//Entity framework configutarion
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevelopmentConnection")));


builder.Services.SetupUnitOfWork();

//Registration of dependencies 
builder.Services.AddScoped<IUserLogin,UserLoginJWT>();
builder.Services.AddScoped<IUserRegister, UserRegister>();
builder.Services.AddScoped<IAuthService, AuthService>();


//builder.Services.AddScoped<IUserRepository,UserRepository>();
//builder.Services.AddScoped<IRecipeRepository,RecipeRepository >();


//TODO: Make and extension class to move all this logic for config swagger
SwaggerConfiguration(builder);

// Add JWT configuration
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true
    };
});

builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();

    
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Foodie Pal API V1");
    });
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

static void SwaggerConfiguration(WebApplicationBuilder builder)
{
    var securityScheme = new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JSON Web Token based security",
    };

    var securityReq = new OpenApiSecurityRequirement()
{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            }
        },
        new string[] {}
    }
};



    var contact = new OpenApiContact()
    {
        Name = "Pablo Muñoz",
        Email = "pablommartinezdev.com",
        //Url = new Uri("")
    };

    var license = new OpenApiLicense()
    {
        Name = "Free License",
        //Url = new Uri("")
    };

    var info = new OpenApiInfo()
    {
        Version = "v1",
        Title = "Foodie Pal - Minimal API",
        Description = "Implementing JWT Authentication in Minimal API",
        //TermsOfService = new Uri(""),
        Contact = contact,
        License = license
    };
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", info);
        options.AddSecurityDefinition("Bearer", securityScheme);
        options.AddSecurityRequirement(securityReq);
    });
}