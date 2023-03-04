using DataAccess.Models;

namespace DataAccess.Infra.Abstract
{
    public interface IVendorInfoRepository
    {
        ProductVendor GetProductVendors();
    }
}
