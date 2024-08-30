using OperatorOverload___Homework12;

GroupMate group = new GroupMate(3);
group.Add(new Student("Gulay", "Mehraliyeva", 18));
group.Add(new Student("John", "Smith", 25));
group.Add(new Student("Bob", "Brown", 20));
group.Sort();

foreach (var student in group.students)
{
    Console.WriteLine($"{student.Name} {student.Surname} {student.Age}");
}
