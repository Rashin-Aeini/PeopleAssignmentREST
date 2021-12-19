using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;
using PeopleAssignmentREST.Models.ViewModels;

namespace PeopleAssignmentREST.Models.Services
{
    public interface ILanguageService
    {
        Language Add(CreateLanguageViewModel language);
        List<Language> All();
        Language FindById(int id);
        bool Edit(int id, CreateLanguageViewModel language);
        bool Remove(int id);
    }
}
