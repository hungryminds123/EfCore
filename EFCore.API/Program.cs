using Core.Concrete;
using Core.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Concrete;
using Persistence.Interface;

namespace EFCore.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<EFCoreLearningDBContext>(
                x =>
                {
                    x.UseSqlServer(builder.Configuration.GetConnectionString("EFCoreConnectionString"));
                });

            // registering dependencies

            builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddTransient<IDepartmentRepository, DepartmentRepository>();

            builder.Services.AddTransient<IEmployeeService, EmployeeService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

          

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}