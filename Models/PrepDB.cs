using Dockersql.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace DockerSQL.Models
{
    public static class PrepDB
    {

        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var servicescope = app.ApplicationServices.CreateScope())
            {
                Seed(servicescope.ServiceProvider.GetService<ColourContext>());
            }
        }
        public static void Seed(ColourContext context)
        {
            System.Console.WriteLine("Appling Migration");
            context.Database.Migrate();
            if (!context.ColourItems.Any())
            {
                System.Console.WriteLine("Adding data. Seeding.....");
                context.ColourItems.AddRange(
                    new Colour() { ColourName = "RED" },
                    new Colour() { ColourName = "White" },
                    new Colour() { ColourName = "Black" },
                    new Colour() { ColourName = "Blue" }
                );
                context.SaveChanges();
            }
            else
                System.Console.WriteLine("Already data present");
        }
    }
}