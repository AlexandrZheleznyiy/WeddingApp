
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Wedding.Contexts;
using Wedding.Services;
namespace Wedding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          

            builder.Services.AddControllers();
        
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IWeddingService, WeddingService>();
            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<WeddingContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("SampleDbConnection")));
            builder.Services.AddControllers().AddJsonOptions(o => { o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; o.JsonSerializerOptions.MaxDepth = 0; });
            var app = builder.Build();

  
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
