using Backend.C1.EndPoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("http://localhost:5257")
            .AllowAnyHeader()
            .AllowAnyMethod()
    )
);
var app = builder.Build();

app.ConfigureReverseEP();

app.ConfigureCollatzCEP();

app.UseCors();

app.Run();