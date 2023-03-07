using System;
using System.Collections.Generic;

namespace MicroservicesModel.Models;

public partial class TblLogin
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
