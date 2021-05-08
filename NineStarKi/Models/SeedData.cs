using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace NineStarKi.Models
{
    public class SeedData
    {
        private MusicContext context;

        private ILogger<SeedData> logger;

        private IRepository repository;

        private List<Genre> Genres = Constants.Genres;

        private List<Occasion> Occasions = Constants.Occasions;

        private List<Musician> Musicians = Constants.Musicians;

        public SeedData(MusicContext dataContext, ILogger<SeedData> log, IRepository repo)
        {
            context = dataContext;
            logger = log;
            repository = repo;
        }

        public void EnsurePopulated()
        {
            if (typeof(Repository).IsAssignableFrom(repository.GetType()))
            {
                repository.AddGenres(Genres);
                repository.AddOccasions(Occasions);
                repository.AddMusicians(Musicians);
                logger.LogInformation("Repository populated");
            }
            else
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (context.Musicians.Count() == 0)
                {
                    logger.LogDebug("Preparing to seed database");

                    foreach (Genre genre in context.Genres)
                    {
                        context.Genres.Remove(genre);
                    }
                    context.Genres!.AddRange(Genres);
                    context.SaveChanges();
                    logger.LogDebug("Genres added");

                    foreach (Occasion occasion in context.Occasions)
                    {
                        context.Occasions.Remove(occasion);
                    }
                    context.Occasions!.AddRange(Occasions);
                    context.SaveChanges();
                    logger.LogDebug("Occasions added");

                    context.Musicians!.AddRange(Musicians);
                    context.SaveChanges();
                    logger.LogDebug("Musicians added");
                    logger.LogInformation("Database seeded");
                }
                else
                {
                    logger.LogInformation("Database not seeded");
                }
            }
        }
    }
}
