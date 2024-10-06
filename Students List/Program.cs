// See https://aka.ms/new-console-template for more information
using Students_List;


static void DisplayStudentsList(List<Student> studentsList)
{
    foreach (var student in studentsList)
        Console.WriteLine(student);
}

Console.WriteLine("Students List\n");

var students = new List<Student>
{
    new Student("Smith", "John", 19, "Computer Science", 85.5, 2021),
    new Student("Doe", "Jane", 20, "Business Administration", 78.2, 2020),
    new Student("Brown", "Michael", 21, "Mechanical Engineering", 92.0, 2019),
    new Student("Taylor", "Emily", 22, "Medicine", 88.1, 2018),
    new Student("Wilson", "Andrew", 23, "History", 74.5, 2022),
    new Student("Davis", "Laura", 24, "Psychology", 81.3, 2020),
    new Student("Miller", "Oliver", 20, "Computer Science", 95.0, 2023),
    new Student("Lee", "Sophia", 19, "Economics", 68.9, 2023),
    new Student("Garcia", "Lucas", 21, "Mathematics", 79.5, 2021),
    new Student("Martinez", "Olivia", 22, "Law", 84.0, 2019)
};

//DisplayStudentsList(students);




