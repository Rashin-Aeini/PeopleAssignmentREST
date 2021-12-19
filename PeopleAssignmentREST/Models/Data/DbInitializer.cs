using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.Data
{
    internal class DbInitializer
    {
        internal static void Initialize(PeopleContext context)
        {
            context.Database.Migrate();

            if (!context.Countries.Any())
            {
                Country sweden = new Country()
                {
                    Name = "Sweden",
                    Cities = new List<City>()
                };

                City gothenburg = new City()
                {
                    Name = "Gothenburg",
                    People = new List<Person>()
                };

                Person aeini = new Person()
                {
                    Name = "Rashin Aeini",
                    Phone = "123456789"
                };

                gothenburg.People.Add(aeini);

                sweden.Cities.Add(gothenburg);

                context.Countries.Add(sweden);

                context.SaveChanges();

            }
        }
    }
}
