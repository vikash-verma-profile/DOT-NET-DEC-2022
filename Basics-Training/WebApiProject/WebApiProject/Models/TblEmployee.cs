using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiProject.Models
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int? DepartmentId { get; set; }
    }
}
