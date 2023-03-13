using DataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace UserFormApp.Models
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<GenderDetail> Gender { get; set; }
        public List<CountryDetail> Countries { get; set; }
        public List<LanguageDetail> Languages { get; set; }
    }
}
