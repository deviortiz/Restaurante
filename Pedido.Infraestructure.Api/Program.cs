using Pedidos.Application.Interfaces;
using Pedidos.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//String? URLORIGIN = Environment.GetEnvironmentVariable("URLORIGIN");


// Add services to the container.

/*
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
                policy =>
                {
                    policy.WithOrigins("http://localhost:3000", "http://10.212.134.107:3000/")
                            .WithMethods("PUT", "DELETE", "GET", "PUT");
                });
});*/

builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors();
var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseStaticFiles();
app.UseRouting();

//app.UseCors("MyPolicy");
app.UseCors(
      options => options.WithOrigins("http://localhost:3000").AllowAnyMethod()
  );
app.MapRazorPages();
app.Run();



