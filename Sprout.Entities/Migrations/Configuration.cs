namespace Sprout.Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sprout.Entities.SproutContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Sprout.Entities.SproutContext context)
        {
            var employees = new[] {
                new Employee { FirstName = "Rob", LastName = "Stan" },
                new Employee { FirstName = "Mark", LastName = "Smith", Address1 = "Blk 1 Lot 2", City = "Makati", PhoneNumber = "241-2312" },
                new Employee { FirstName = "James", LastName = "Martins", Address1 =  "1st Floor Arcadia Bldg", City = "Makati", PhoneNumber = "241-2312" }
            };
            context.Employees.AddOrUpdate(p => p.LastName, employees);

            context.SaveChanges();
        }
    }
}
