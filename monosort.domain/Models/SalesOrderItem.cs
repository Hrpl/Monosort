using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain.Models;

public class SalesOrderItem : BaseModel
{
    public int Quantity { get; set; }
    public Product Product { get; set; }
}
