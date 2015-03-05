using System.Collections.Generic;
using SharpFlashCard.Models;

namespace SharpFlashCard.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SharpFlashCard.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SharpFlashCard.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            GameLogic gameLogic = new GameLogic();

            gameLogic.ReadFile();

        }
    }
}
