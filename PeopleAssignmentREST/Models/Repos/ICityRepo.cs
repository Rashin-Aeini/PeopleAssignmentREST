using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.Repos
{
    public interface ICityRepo
    {
        List<City> Read();
        City Read(int id);
        City Create(City entry);
        bool Update(City entry);
        bool Delete(City entry);
    }
}
