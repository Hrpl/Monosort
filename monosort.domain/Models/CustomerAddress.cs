using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain.Models;

public class CustomerAddress : BaseModel
{
    public string Country {  get; set; }
    public string Address { get; set; }
}
