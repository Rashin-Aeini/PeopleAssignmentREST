using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;
using PeopleAssignmentREST.Models.ViewModels;

namespace PeopleAssignmentREST.Models.Services
{
    public interface ICityService
    {
        City Add(CreateCityViewModel city);
        List<City> All();
        City FindById(int id);
        bool Edit(int id, CreateCityViewModel city);
        bool Remove(int id);
    }
}
