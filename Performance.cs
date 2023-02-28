string city="Delhi";
List<Schools> schools=db.Schools.where(s=>s.city
="New Delhi").ToList();
var sb=new StringBuilder();
foreach(var school in schools)
{
	sb.append(school.Name);
	sb.append(": ");
	sb.append(school.student.count)
	sb.append(Enviornment.NewLine);
}