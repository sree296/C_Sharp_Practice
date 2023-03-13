﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Abstract
{
    public interface IUserDetailsRepo
    {
        List<CountryDetail> GetCountryDetails();
        List<GenderDetail> GetGenderDetails();
        List<LanguageDetail> GetLanguageDetails();
    }
}
