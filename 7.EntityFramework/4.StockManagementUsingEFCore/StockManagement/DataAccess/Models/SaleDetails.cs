using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class SaleDetails
    {
       [Key]
       public int SalesID { get; set; }
       public int ProductId { get; set; }
       public DateTime? SalesDate { get; set; }
       public int SalesQty { get; set; }
    }
}
