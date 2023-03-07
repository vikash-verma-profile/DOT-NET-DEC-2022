using System;
using System.Collections.Generic;

namespace MicroservicesModel.Models;

public partial class TblOrder
{
    public int Id { get; set; }

    public string? OrderNumber { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? UserId { get; set; }
}
