﻿using System;
using System.Collections.Generic;

namespace Harmic.Models;

public partial class TbOrderStatus
{
    public int OrderStatusId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual TbOrder OrderStatus { get; set; } = null!;
}
