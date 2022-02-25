using System.Linq;
using System.Collections.Generic;

var list = new List<Student>();
list.Add(new Student() { RollNo = 1, Name = "Abdullah"});
list.Add(new Student() { RollNo = 2, Name = "Arslan"});
list.Add(new Student() { RollNo = 3, Name = "Ibrahim"});

var q = from s in list.AsQueryable()
        where s.Name.StartsWith("A")
        select new { s.RollNo, s.Name };
foreach(var i in q)
    Console.WriteLine(i.Name);

record Student(int RollNo, string Name);