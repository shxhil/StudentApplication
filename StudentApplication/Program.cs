
using Microsoft.EntityFrameworkCore;
using StudentEnrolment.data;

namespace StudentApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            //>>connection string to make connection with string
            //give acces to all configuration files  
            var connection = builder.Configuration.GetConnectionString("SchoolDbConnection");
            builder.Services.AddDbContext<StudentEnrollmentDBContext>(options => 
            {
               options.UseSqlServer(connection);
            });



            // Add services to the container.


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy => policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });

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
                                   //async  allow server to handle other requests while waiting
            app.MapGet("/Courses", async(StudentEnrollmentDBContext context) =>
            {           //to run without blocking the main thread
                return  await context.Courses.ToListAsync();
            });

            app.MapGet("/Courses/{id}", async (StudentEnrollmentDBContext context, int id) =>
            {
               return await context.Courses.FindAsync(id) is Course course ? Results.Ok(course) : Results.NotFound("Not found");

            });

            app.Run();
        }
    }
}
