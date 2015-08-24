namespace MyFirstWebsite.Migrations
{
    using MyFirstWebsite.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyFirstWebsite.Models.MyWebPageDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyFirstWebsite.Models.MyWebPageDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.Games.AddOrUpdate(r => r.Name,
                new Game { Name = "Witcher 3", Genre = "Open world RPG", Description = "Geralt the witcher is cool", Publisher = "CD Projekt RED", Developer = "CD Projekt RED" },
                new Game { Name = "Pillars of Eternity", Genre = "Classic RPG", Description = "Saved Obsidian's ass", Publisher = "Obsidian", Developer = "Obsidian" },
                new Game
                {
                    Name = "Diablo 3",
                    Genre = "Action RPG",
                    Description = "Not Diablo 2",
                    Publisher = "Blizzard",
                    Developer = "Blizzard",
                    Reviews =
                        new List<GameReview> { 
                        new GameReview { Rating = 7, Body = "Fast paced, but incredibly repetitive.", ReviewerName = "Nicolai" }
                        }
                }
                );
        }
    }
}
