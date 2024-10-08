﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain.Models;

public class ProductInventorySnapshot
{
    public int Id { get; set; }
    public DateTime SnapshotTime { get; set; }
    public int QuantityOnHand { get; set; }
    public Product Product { get; set; }
}
