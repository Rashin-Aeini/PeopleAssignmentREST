using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;
using PeopleAssignmentREST.Models.ViewModels;

namespace PeopleAssignmentREST.Models.Services
{
    public interface IPeopleService
    {
        Person Add(CreatePersonViewModel person);
        List<Person> All();
        List<Person> Search(string search);
        Person FindById(int id);
        bool Edit(int id, CreatePersonViewModel person);
        bool Remove(int id);
        LanguageCoverageViewModel LanguageCoverage(int id);
        bool AddLanguage(int id, int language);
        bool RemoveLanguage(int id, int language);

    }
}
