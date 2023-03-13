using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Implementation
{
    public class UserDetailsRepo : IUserDetailsRepo
    {
        UserManagementContext _context = new UserManagementContext();

        public List<CountryDetail> GetCountryDetails()
        {
            List<CountryDetail> countryList = new List<CountryDetail>();

            try
            {
                countryList = _context.CountryDetailsData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return countryList;
        }

        public List<GenderDetail> GetGenderDetails()
        {
            List<GenderDetail> genderList = new List<GenderDetail>();

            try
            {
                genderList = _context.GenderDetailsData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return genderList;
        }

        public List<LanguageDetail> GetLanguageDetails()
        {
            List<LanguageDetail> langList = new List<LanguageDetail>();

            try
            {
                langList = _context.LanguageDetailsData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return langList;
        }
    }
}
