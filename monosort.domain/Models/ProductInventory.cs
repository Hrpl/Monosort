using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain.Models;

public class ProductInventory : BaseModel
{
    public int QuantityOnHand { get; set; }
    public int IdealQuantity {  get; set; }
    public Product Product { get; set; }
}
