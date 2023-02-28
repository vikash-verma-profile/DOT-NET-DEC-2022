using Performance.Models;
using System.Text;
using System;

namespace Performance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Delhi";
            SchoolDbContext db = new SchoolDbContext();
            List<School> schools = db.Schools.Where(s => s.City == city).ToList();
            var sb = new StringBuilder();
            foreach (var school in schools)
            {
                sb.Append(school.Name);
                sb.Append(": ");
                sb.Append(school.Students.Count);
                sb.Append(Environment.NewLine);
            }
        }
    }
}