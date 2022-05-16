using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RestAPIStart.Repository;
using ThisRestBL;
using ThisRestDL;
using System.Text;


string connectionStringFilePath = "../../../../ThisRestDL/Database/thisCommandString.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

var builder = WebApplication.CreateBuilder(args);
//In order to access the JWT token info we need to use this variable:
ConfigurationManager configMan = builder.Configuration;

// Add services to the container.

//This is the tried and tested use, and reuse of the JWT security. Use this on all Security configs.
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(bearer =>
{
    var key = Encoding.UTF8.GetBytes(configMan["JWT:Key"]);
    bearer.SaveToken = true;
    bearer.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidIssuer = configMan["JWT:Issuer"],
        ValidAudience = configMan["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateLifetime = true,
        ValidateIssuer = false,
        ValidateAudience = false,
    };
});
builder.Services.AddMemoryCache();
builder.Services.AddControllers(options =>
    options.RespectBrowserAcceptHeader = true
    ).AddXmlSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRestaurantRepo>(repo => new SqlRepository(connectionString));
builder.Services.AddScoped<IRestaurantLogic, RestaurantLogic>();
builder.Services.AddSingleton<IJWTManagerRepository, JWTManagerRepository>();
// The below var relates to the 'app' using pipeline middleware
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
