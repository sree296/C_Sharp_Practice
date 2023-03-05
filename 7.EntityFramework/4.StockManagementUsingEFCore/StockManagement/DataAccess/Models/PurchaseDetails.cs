using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PurchaseDetails
    {
       [Key]
       public int PurchaseId { get; set; }
       public int ProductId { get; set; }
       public DateTime? PurchaseDate { get; set; }
       public int PurchaseQty { get; set; }
    }
}
