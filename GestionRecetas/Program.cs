using Microsoft.AspNetCore.Identity;
using GestionRecetas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionRecetas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("UsuarioRolAsignado", policy =>
                    policy.RequireRole("Administrador", "Usuario"));
            });

            builder.Services.AddAuthorization();
            builder.Services.AddAuthentication()
                .AddCookie(IdentityConstants.ApplicationScheme);

            builder.Services.AddIdentityCore<Usuario>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<RecetasDBContext>()
                .AddApiEndpoints();

            builder.Services.AddDbContext<RecetasDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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

            app.MapIdentityApi<Usuario>();

            app.Run();
        }
    }
}
