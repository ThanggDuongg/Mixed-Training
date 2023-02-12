using Queryable;

List<Student> students = new List<Student>() { 
    new Student(1, "Nguyen Van A", "Hoc sinh", 10),
    new Student(2, "Nguyen Van B", "Sinh Vien", 21),
    new Student(3, "Nguyen Van C", "Hoc sinh", 9),
    new Student(4, "Nguyen Van D", "Sinh Vien", 18),
    new Student(5, "Nguyen Van E", "Hoc sinh", 16),
};

var NQueryable = students.Where(x => x.Id <= 3).OrderBy(x => x.Id);
var Queryable = students.AsQueryable().Where(x => x.Id <= 3).OrderBy(x => x.Id);
//var Queryable = students.AsQueryable().Where(x => x.Age > 16);

int flag = 0;

//foreach (var student in NQueryable.ToList())
foreach (var student in Queryable.ToList())
{
    Console.WriteLine(student.Name);
}