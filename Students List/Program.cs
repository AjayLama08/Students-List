// See https://aka.ms/new-console-template for more information
using Students_List;
using System.Linq;


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

students.AddRange(new List<Student>
{
    new Student("Anderson", "Chloe", 18, "Biology", 90.0, 2022),
    new Student("Thomas", "Noah", 22, "Mechanical Engineering", 87.4, 2020),
    new Student("Jackson", "Isabella", 20, "Computer Science", 72.6, 2023),
    new Student("Harris", "Ethan", 21, "Business Administration", 85.8, 2021),
    new Student("White", "Ava", 23, "Medicine", 93.2, 2018),
    new Student("Thompson", "Mason", 24, "Psychology", 77.9, 2019),
    new Student("Moore", "Sophia", 19, "History", 81.7, 2023),
    new Student("Martin", "James", 22, "Economics", 75.4, 2020),
    new Student("Garcia", "Ella", 20, "Law", 88.5, 2021),
    new Student("Rodriguez", "Benjamin", 21, "Mathematics", 91.6, 2022),
    new Student("Lewis", "Emily", 19, "Mechanical Engineering", 73.3, 2023),
    new Student("Walker", "Liam", 22, "Business Administration", 76.4, 2020),
    new Student("Young", "Samantha", 23, "Psychology", 89.1, 2021),
    new Student("Allen", "Lucas", 21, "Computer Science", 94.7, 2022),
    new Student("King", "Sophia", 24, "Biology", 78.0, 2019),
    new Student("Wright", "Daniel", 20, "History", 80.2, 2020),
    new Student("Scott", "Ella", 18, "Medicine", 82.3, 2021),
    new Student("Green", "Jack", 19, "Mechanical Engineering", 88.0, 2022)
});

//DisplayStudentsList(students);

//Console.WriteLine("\nStudents enrolled in Computer Science sorted by their marks in descending order");
//var computerSciencestudents = students.Where(s => s.Course == "Computer Science").OrderByDescending(s => s.Mark).ToList(); ;
//DisplayStudentsList(computerSciencestudents);

//Console.WriteLine("\nStudents who enrolled after the year 2020");
//var enrolledAfter2020 = students.Where(s => s.EnrolmentYear > 2020).OrderBy(s => s.EnrolmentYear).ToList();
//DisplayStudentsList(enrolledAfter2020);

//Console.WriteLine("\nAverage mark by course");
//var avgMarkByCourse = students.GroupBy(s => s.Course).Select(g => new
//{
//    Course = g.Key,
//    Average = g.Average(s => s.Mark)
//});

//foreach(var avgMark in avgMarkByCourse)
//{
//    Console.WriteLine($"{avgMark.Course}: {avgMark.Average}");
//}

//Console.WriteLine("\nYoungest student in each course:");
//var youngestStudent = students.GroupBy(s => s.Course).Select(g => g.OrderBy(s => s.Age).First());
//foreach (var youngStd in youngestStudent)
//{
//    Console.WriteLine($"Course: {youngStd.Course}, Name: {youngStd.Forename} {youngStd.Surname}, Age: {youngStd.Age}");
//}

//Console.WriteLine("\nCount students by enrolment year:");
//var countByEnrolmentYear = students.GroupBy(s => s.EnrolmentYear).OrderBy(g => g.Key).Select(g => new
//{
//    EnrolmentYear = g.Key,
//    Count = g.Count()
//}).ToList();

//foreach (var cby in countByEnrolmentYear)
//{
//    Console.WriteLine($"{cby.EnrolmentYear}: {cby.Count}");
//}

//Console.WriteLine("Students with marks between 70 and 85:");
//var markRange = students.Where(s => s.Mark >= 70 && s.Mark <= 85).OrderBy(s => s.Mark).Select(s => new
//{
//    Forename = s.Forename,
//    Surname = s.Surname,
//    Mark = s.Mark
//});
//foreach (var mr in markRange)
//{
//    Console.WriteLine($"Name: {mr.Forename} {mr.Surname}, Mark: {mr.Mark}");
//}

//Console.WriteLine("\nStudents older than 21 and sorted by their mark in descending order:");
//var studentOlderThan21 = students.Where(s => s.Age > 21).OrderByDescending(s => s.Mark).Select(s => new
//{
//    Forename = s.Forename,
//    Surname = s.Surname,
//    Age = s.Age,
//    Mark = s.Mark
//});
//foreach(var stdOldThan21 in studentOlderThan21)
//{
//    Console.WriteLine($"Name: {stdOldThan21.Forename} {stdOldThan21.Surname}, Age: {stdOldThan21.Age}, Mark: {stdOldThan21.Mark}");
//}

//Console.WriteLine("\nTop 3 students with the highest marks.");
//var top3Student = students.OrderByDescending(s => s.Mark).Select(s => new
//{
//    Forename = s.Forename,
//    Surname = s.Surname,
//    Mark = s.Mark
//}).Take(3);
//foreach(var top3 in top3Student)
//{
//    Console.WriteLine($"Name: {top3.Forename} {top3.Surname}, Mark: {top3.Mark}");
//}




