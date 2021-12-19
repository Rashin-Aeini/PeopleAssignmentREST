﻿using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.ViewModels
{
    public class CitiesViewModel
    {
        public CitiesViewModel()
        {
            Result = new List<City>();
        }

        public string Search { get; set; }




        public List<City> Result { get; }
    }
}
