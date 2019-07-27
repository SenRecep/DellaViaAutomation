

namespace DellaViaAutomation.Dal.ComplexType.EntityFramework.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DellaViaAutomationDbModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DellaViaAutomationDbModel context)
        {
          
        }
    }
}
