<<<<<<< HEAD
using Microsoft.OpenApi.Models;
using NajotEdu.Application;
=======
>>>>>>> 0952f8cb34f80001a7cf33967d834159b9c35193
using NajotEdu.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
<<<<<<< HEAD


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

=======
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);
>>>>>>> 0952f8cb34f80001a7cf33967d834159b9c35193

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
