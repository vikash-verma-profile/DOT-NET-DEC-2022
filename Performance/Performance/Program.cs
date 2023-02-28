using Performance.Models;
using System.Text;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Performance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Delhi";
            SchoolDbContext db = new SchoolDbContext();
            /*
            //n+1 problem
           Problem-1
          
            List<School> schools = db.Schools.Where(s => s.City == city).ToList();
            var sb = new StringBuilder();
            foreach (var school in schools)
            {
                sb.Append(school.Name);
                sb.Append(": ");
                sb.Append(school.Students.Count);
                sb.Append(Environment.NewLine);
            }
            //solutions Eager loading
            List<School> Sch = db.Schools.Where(s=>s.City==city).Include(x=>x.Students).ToList();
            */

            /*
            List<School> schools = db.Schools.Where(s => s.City == city).ToList();
            List<School> DelhiSchools = schools.Where(s => s.Students.Count>100).ToList();

            List<School> Solschools = db.Schools.Where(s => s.City == city).Include(x=>x.Students).ToList();
            List<School> SolDelhiSchools = Solschools.Where(s => s.Students.Count > 100).ToList();

            List<School> Solschools2 = db.Schools.Where(s => s.City == city && s.Students.Count>100).ToList();
            */

            //being too gready for the colums

            /*
            int schoolid = 1;
            List<Student> students = db.Students.Where(p=>p.SchoolId== schoolid).ToList();
            var Objstudents = db.Students.Where(p => p.SchoolId == schoolid).Select(x=> new {x.FirstName,x.LastName}).ToList();
            var print = " ";
            foreach (var item in students)
            {
                print += item.FirstName + " " + item.LastName;
                print += "\n";
            }
            */
            //Mismatched data types

            //string zipCode = "122001";
            //var students = db.Students.Where(p => p.PostalZipCode == zipCode).Select(x=> new 
            //{ x.FirstName,x.LastName }).ToList();

            //Missing Indexes

            var students = db.Students.Where(p=>p.City==city).OrderBy(p=>p.LastName).
                Select(x=> new { x.FirstName, x.LastName }).ToList();
        }
    }
}