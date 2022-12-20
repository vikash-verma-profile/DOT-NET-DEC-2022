using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject.Models;
using WebApiProject.ViewModel;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //IEnumerable<EmployeeDetails>
        DemoAdoDBContext db = new DemoAdoDBContext();
        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            //var result= db.TblEmployees.LeftJoin(db.TblDepartments,e=>e.DepartmentId,d=>d.Id,(e,d)=> new EmployeeDetails { Id=e.Id,FirstName=e.FirstName,LastName=e.LastName,Gender=e.Gender,Department=d.Department });
            var result = db.TblEmployees.GroupJoin(db.TblDepartments, e => e.DepartmentId, d => d.Id,
                 (e, d) => new { e, d }).SelectMany(x=>x.d,(employee, depart) =>new { employee, depart });
            //SelectMany(x=>x.d.,(employee,depart)=>new  EmployeeDetails { Id = employee.e.Id, FirstName = employee.e.FirstName, LastName = employee.e.LastName, Gender = employee.e.Gender, Department = depart.Department });

            return result;
            //return Ok();
        }
    }
}
