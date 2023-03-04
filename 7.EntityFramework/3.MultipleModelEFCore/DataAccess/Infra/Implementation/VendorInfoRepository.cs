using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;

namespace DataAccess.Infra.Implementation
{
    public class VendorInfoRepository : IVendorInfoRepository
    {
        VendorManagementContext _context = new VendorManagementContext();
        
        public ProductVendor GetProductVendors()
        {
            ProductVendor prodObj = new ProductVendor();
            List<VendorInfo> vendorsList = _context.VendorDetailData.ToList();
            List<Product> productsList = _context.ProductData.ToList();

            prodObj.VendorsList = vendorsList;
            prodObj.ProductsList = productsList;

            return prodObj;
        }
    }
}
