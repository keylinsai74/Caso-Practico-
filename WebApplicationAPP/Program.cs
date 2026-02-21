using Microsoft.EntityFrameworkCore;
using System;
using WebApplicationAPP.Busines;
using WebApplicationAPP.Business;
using WebApplicationAPP.Data;
using WebApplicationAPP.Repositories;


namespace WebApplicationAPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseMySql(
                    builder.Configuration.GetConnectionString("MysqlConnection"),
                    ServerVersion.AutoDetect(
                        builder.Configuration.GetConnectionString("MysqlConnection")
                    )
                );
            });


            builder.Services.AddScoped<IPersonaRepository, PersonaRepository>();
            builder.Services.AddScoped<PersonaBussiness>();
            builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
            builder.Services.AddScoped<ProductoBusiness>();
            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
            builder.Services.AddScoped<IInventarioRepository, InventarioRepository>();
            builder.Services.AddScoped<InventarioBusiness>();


            builder.Services.AddScoped<ClienteBusiness>();

            //Repositorio
            //CapaBussine


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
