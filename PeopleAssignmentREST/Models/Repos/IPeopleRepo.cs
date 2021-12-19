using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.Repos
{
    public interface IPeopleRepo
    {
        List<Person> Read();
        Person Read(int id);
        Person Create(Person entry);
        bool Update(Person entry);
        bool Delete(Person entry);
    }
}
