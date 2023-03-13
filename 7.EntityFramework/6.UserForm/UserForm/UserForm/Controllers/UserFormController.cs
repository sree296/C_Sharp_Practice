using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using UserFormApp.Models;

namespace UserFormApp.Controllers
{
    public class UserFormController : Controller
    {
        IUserDetailsRepo _userObj = new UserDetailsRepo();
        public IActionResult Index()
        {
            UserDetail userDetailsView = new UserDetail();

            List<CountryDetail> countryList = _userObj.GetCountryDetails();
            List<LanguageDetail> langList = _userObj.GetLanguageDetails();
            List<GenderDetail> genderList = _userObj.GetGenderDetails();

            userDetailsView.Countries = countryList;
            userDetailsView.Languages = langList;
            userDetailsView.Gender = genderList;

            return View();
        }
    }
}
