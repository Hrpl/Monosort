using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain.Models;

public class Product : BaseModel
{
    [MaxLength(64)]
    public string Name { get; set; }
    [MaxLength(108)]
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsTaxable {  get; set; }
}
