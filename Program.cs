
using Microsoft.EntityFrameworkCore;
using WebAssignment_Quiz_.Data;
using WebAssignment_Quiz_.Repos.AuthorRepo;
using WebAssignment_Quiz_.Repos.BookRepo;
using WebAssignment_Quiz_.Repos.GenreRepo;

namespace WebAssignment_Quiz_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            builder.Services.AddScoped<IBookRepo, BookRepo>();
            builder.Services.AddScoped<IAuthorRepo, AuthorRepo>();
            builder.Services.AddScoped<IGenreRepo, GenreRepo>();
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
