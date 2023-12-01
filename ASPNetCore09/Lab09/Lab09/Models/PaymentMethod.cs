﻿using System;
using System.Collections.Generic;

namespace Lab09.Models;

public partial class PaymentMethod
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public byte? Isdelete { get; set; }

    public byte? Isactive { get; set; }
}
