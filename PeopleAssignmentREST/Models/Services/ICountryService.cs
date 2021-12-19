using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;
using PeopleAssignmentREST.Models.ViewModels;

namespace PeopleAssignmentREST.Models.Services
{
    public interface ICountryService
    {
        Country Add(CreateCountryViewModel country);
        List<Country> All();
        Country FindById(int id);
        bool Edit(int id, CreateCountryViewModel country);
        bool Remove(int id);
    }
}
