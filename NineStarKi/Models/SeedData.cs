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
        private IEnumerable<Genre> Genres;
        private IEnumerable<Occasion> Occasions;
        private IEnumerable<Musician> Musicians;

        public SeedData(MusicContext dataContext, ILogger<SeedData> log, 
            IRepository repo, ConstantData constants)
        {
            context = dataContext;
            logger = log;
            repository = repo;
            Genres = constants.Genres;
            Occasions = constants.Occasions;
            Musicians = constants.Musicians;
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

                if (context.Musicians.Count() == 0
                    && context.Genres.Count() == 0
                    && context.Occasions.Count() == 0)
                {
                    logger.LogDebug("Preparing to seed database");

                    context.Genres!.AddRange(Genres);
                    context.SaveChanges();
                    logger.LogDebug("Genres added");

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
