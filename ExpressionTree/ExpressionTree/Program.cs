using ExpressionTree;
using System.Linq;
using System.Linq.Expressions;

List<Student> stdl = new List<Student>() { new Student(1, "1", 10), new Student(2, "2", 20) };
Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age <= 20;
isTeenAgerExpr.Compile();
Student temp = stdl.AsQueryable().FirstOrDefault(isTeenAgerExpr);
Console.WriteLine(temp.Name);

//Filter(source, (item) => item.Age > 10 && item.Age <= 20).ToList().ForEach(item => Console.WriteLine(item.Name));

//IEnumerable<T> Filter<T>(IEnumerable<T> source, Expression<Func<T, bool>> func)
//{
//    foreach (var item in source)
//    {
//        if ()
//        {
//            yield return item;
//        }
//    }
//}

