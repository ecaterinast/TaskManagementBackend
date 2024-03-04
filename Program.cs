using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.Initialization;
using Microsoft.Extensions;
using System.Configuration;
public class Program
{
    public static void Main(string[] args)
    {
        DbInitialiser.ApplyMigrations<DataContext>("Server =.; Database =TaskManagementDb; Trusted_Connection = True; TrustServerCertificate = True;");

        var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer("Server =.; Database =TaskManagementDb; Trusted_Connection = True; TrustServerCertificate = True;")); ;

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}