using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.Repos
{
    public interface ICountryRepo
    {
        List<Country> Read();
        Country Read(int id);
        Country Create(Country entry);
        bool Update(Country entry);
        bool Delete(Country entry);
    }
}
