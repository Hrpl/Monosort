using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain.Models;

public class SalesOrder : BaseModel
{
    public Customer Customer { get; set; }
    public List<SalesOrderItem> SalesOrderItems { get; set; }
    public bool IsPaid { get; set; }
}
