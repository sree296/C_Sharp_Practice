using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace MultipleModelEFCore.Controllers
{
    public class ProductVendorController : Controller
    {
        IVendorInfoRepository _obj = new VendorInfoRepository();
        [HttpGet]
        public IActionResult GetProductsAndVendors()
        {
            ProductVendor objData = _obj.GetProductVendors();

            return View(objData);
        }
    }
}
