namespace GoParty.Api
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GoPartyDbContext, Configuration>());
            GoPartyDbContext.Create().Database.Initialize(true);
        }
    }
}
