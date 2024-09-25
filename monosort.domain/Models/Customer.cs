using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain.Models;

public class Customer : BaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public CustomerAddress Address { get; set; }
}
