using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace NineStarKi.Models
{
    public static class SeedData
    {
        public static void CreateDBContext(IApplicationBuilder app)
        {
            PDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<PDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (context.Personalities.Any())
            {
                foreach (var p in context.Personalities)
                {
                    context.Personalities.Remove(p);
                }
                context.SaveChanges();
            }

            if (!context.Musicians.Any())
            {
                context.Genres.AddRange(
                    new Genre { Name = "BLUES" },
                    new Genre { Name = "CLASSICAL" },
                    new Genre { Name = "COUNTRY" },
                    new Genre { Name = "ELECTRONICA" },
                    new Genre { Name = "FOLK" },
                    new Genre { Name = "GOSPEL" },
                    new Genre { Name = "HIP-HOP" },
                    new Genre { Name = "JAZZ" },
                    new Genre { Name = "MUSICALS" },
                    new Genre { Name = "OPERA" },
                    new Genre { Name = "POP" },
                    new Genre { Name = "R&B" },
                    new Genre { Name = "ROCK" },
                    new Genre { Name = "VOCALS" },
                    new Genre { Name = "WORLD" },
                    new Genre { Name = "Algeria" },
                    new Genre { Name = "Andes" },
                    new Genre { Name = "Angola" },
                    new Genre { Name = "Argentina" },
                    new Genre { Name = "Armenia" },
                    new Genre { Name = "Brazil" },
                    new Genre { Name = "Bulgaria" },
                    new Genre { Name = "Cameroon" },
                    new Genre { Name = "Cape Verde" },
                    new Genre { Name = "Celtic" },
                    new Genre { Name = "China" },
                    new Genre { Name = "Colombia" },
                    new Genre { Name = "Congo" },
                    new Genre { Name = "Cuba" },
                    new Genre { Name = "Dominican Republic" },
                    new Genre { Name = "Egypt" },
                    new Genre { Name = "Ethiopia" },
                    new Genre { Name = "Germany" },
                    new Genre { Name = "Greece" },
                    new Genre { Name = "Guinea" },
                    new Genre { Name = "Haiti" },
                    new Genre { Name = "Hawaii" },
                    new Genre { Name = "Hebrew" },
                    new Genre { Name = "Hungary" },
                    new Genre { Name = "India" },
                    new Genre { Name = "Indonesia" },
                    new Genre { Name = "Iran" },
                    new Genre { Name = "Jamaica" },
                    new Genre { Name = "Japan" },
                    new Genre { Name = "Klezmer" },
                    new Genre { Name = "Latin" },
                    new Genre { Name = "Latin America" },
                    new Genre { Name = "Madagascar" },
                    new Genre { Name = "Mali" },
                    new Genre { Name = "Mauritania" },
                    new Genre { Name = "Mexico" },
                    new Genre { Name = "Middle East" },
                    new Genre { Name = "Morocco" },
                    new Genre { Name = "Nigeria" },
                    new Genre { Name = "Pakistan" },
                    new Genre { Name = "Puerto Rico" },
                    new Genre { Name = "Portugal" },
                    new Genre { Name = "Romania" },
                    new Genre { Name = "Russia" },
                    new Genre { Name = "Senegal" },
                    new Genre { Name = "South Africa" },
                    new Genre { Name = "Spain" },
                    new Genre { Name = "Tanzania" },
                    new Genre { Name = "Trinidad" },
                    new Genre { Name = "Turkey" },
                    new Genre { Name = "Venezuela" },
                    new Genre { Name = "Zimbabwe" }
                );

                context.Occasions.AddRange(
                    new Occasion { Name = "ИГРАТЬ ДЛЯ ДЕТЕЙ" },
                    new Occasion { Name = "УЛУЧШИТЕЛИ РОМАНТА" },
                    new Occasion { Name = "СУПЕРМАН НАУШНИКИ" },
                    new Occasion { Name = "ЛЕДНОЕ ВОСКРЕСЕНЬЕ УТРО" },
                    new Occasion { Name = "КАРДИО ТРЕНИРОВКА" },
                    new Occasion { Name = "МУЗЫКА ДЛЯ ВОЖДЕНИЯ ОТРАЖЕНИЯ" },
                    new Occasion { Name = "КОКТЕЙЛЬНЫЙ ЧАС" },
                    new Occasion { Name = "ПУСТЬ НАЧНЕТСЯ ВЕЧЕРИНКА" },
                    new Occasion { Name = "ДОРОЖНЫЙ САУНДТРЕК AM" },
                    new Occasion { Name = "ДОРОЖНЫЙ САУНДТРЕК PM" },
                    new Occasion { Name = "ПУТЕШЕСТВИЕ НАУШНИКОВ" },
                    new Occasion { Name = "МУЗЫКАЛЬНОЕ ПРИКЛЮЧЕНИЕ" }
                );
                context.SaveChanges();
            }
        }
    }
}
