var students = new List<Student>();

var toshmat = new Student() { Id = 0, Name = "Toshmat" };
students.Add(toshmat);
students.Add(new Student() { Id = 1, Name = "Eshmat"});
students.Add(new Student() { Id = 2, Name = "Eshmat1"});
students.Add(new Student() { Id = 3, Name = "Eshmat2"});
students.Add(new Student() { Id = 4, Name = "Eshmat3"});
students.Add(new Student() { Id = 5, Name = "Eshmat4"});

students[1] = new Student();

Console.WriteLine(students.Contains(toshmat));
Console.WriteLine(students.Contains(new Student()
{
    Id = 1,
    Name = "Eshmat"  
}));

var studensB = new List<Student>(students);