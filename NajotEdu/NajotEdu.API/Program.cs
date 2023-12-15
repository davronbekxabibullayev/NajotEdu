using Microsoft.OpenApi.Models;
using NajotEdu.Application;
using NajotEdu.Infrastructure;

Console.Title = "NajotEdu API";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor(); // bu bizga hohlagan joyizdan contextni
                                           // olishga ruhsat beradi. Aks holda faqat ControllerBase dan 
                                           // voris olgan classlarda ishltilgan bulardi
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

// shu yerda swaggerga options qushib unga olingan tokenni 
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("V1", new OpenApiInfo()// qanday tipdagi endpoint ochishimiz yozilgan
    {
        Version = "V1",
        Title = "NajotEdu",
        Description = "NajotEdu description"

    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,// shu joyda headerga tokenni qushib berishini belgilayapmiz
        Description = "Bearer Authentication",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference()
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }

            },
        new List<string>()
        }
    });

});

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("V1/swagger.json", "NajotEdu API");
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
