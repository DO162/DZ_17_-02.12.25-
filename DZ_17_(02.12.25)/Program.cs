using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 1️ - ПІБ
class Person
{
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public string? Lastname { get; set; }
}

// 2️ - Адреса
class Address
{
    public string? Country { get; set; }
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public int HouseNumber { get; set; }
    public short PostalCode { get; set; }
}

// 3️ - Дата нарождения
class BirthInfo
{
    public DateTime BirthDate { get; set; }
}

// 4️ - Інформація про період навчання
class StudyPeriod
{
    public DateTime StartDate { get; set; }
}

// 5 - Інформація про курс
class KursInfo
{
    public int Kurs { get; set; }
    public string? Specialization { get; set; }
}

// 6 - Інформація про групу
class GroupInfo
{
    public string? GroupName { get; set; }
    public int StudentsCount { get; set; }
}

// 7 - Відвідуваність
class Attendance
{
    public int LessonsVisited { get; set; }
    public int LessonsLate { get; set; }
}

// 8 - Предмет
class Subject
{
    public string? SubjectName { get; set; }
}

// 9 - Викладач
class Teacher : Person
{
}

// 10 - Оцінки
class Grades
{
    public List<int> DzRates { get; set; } = new List<int>();
    public List<int> PracticeRates { get; set; } = new List<int>();
    public List<int> ExamRates { get; set; } = new List<int>();
    public List<int> ZachetRates { get; set; } = new List<int>();

    // Метод для виводу оцінок та їх середніх значень
    public void PrintAverages()
    {
        double dzAvg = DzRates.Count > 0 && DzRates.Count <= 12 ? DzRates.Average() : 0;
        double practiceAvg = PracticeRates.Count > 0 && PracticeRates.Count <= 12 ? PracticeRates.Average() : 0;
        double examAvg = ExamRates.Count > 0 && ExamRates.Count <= 12 ? ExamRates.Average() : 0;
        double zachetAvg = ZachetRates.Count > 0 && ZachetRates.Count <= 12 ? ZachetRates.Average() : 0;

        double totalAverage = (dzAvg + practiceAvg + examAvg + zachetAvg) / 4;

        Console.WriteLine("— Оцiнки студента:");
        Console.WriteLine($"  ДЗ: {string.Join(", ", DzRates)} (Середній: {dzAvg:F2})");
        Console.WriteLine($"  Практики: {string.Join(", ", PracticeRates)} (Середній: {practiceAvg:F2})");
        Console.WriteLine($"  Екзамени: {string.Join(", ", ExamRates)} (Середній: {examAvg:F2})");
        Console.WriteLine($"  Заліки: {string.Join(", ", ZachetRates)} (Середній: {zachetAvg:F2})");
        Console.WriteLine($"  Загальний середній бал: {totalAverage:F2}");
    }
}

//-----------------------------------------------
class Student
{
    public Person Name { get; set; }
    public Address Address { get; set; }
    public BirthInfo Birth { get; set; }
    public StudyPeriod StudyPeriod { get; set; }
    public KursInfo KursInfo { get; set; }
    public GroupInfo GroupInfo { get; set; }
    public Attendance Attendance { get; set; }
    public Subject Subject { get; set; }
    public Teacher Teacher { get; set; }
    public Grades Grades { get; set; }

    public Student()
    {
        Name = new Person();
        Address = new Address();
        Birth = new BirthInfo();
        StudyPeriod = new StudyPeriod();
        KursInfo = new KursInfo();
        GroupInfo = new GroupInfo();
        Attendance = new Attendance();
        Subject = new Subject();
        Teacher = new Teacher();
        Grades = new Grades();
    }

    public void PrintInfo()
    {
        Console.WriteLine("===== ІНФОРМАЦІЯ ПРО СТУДЕНТА =====\n");

        Console.WriteLine("— ПІБ:");
        Console.WriteLine($"  Ім'я: {Name.FirstName}");
        Console.WriteLine($"  Прізвище: {Name.Surname}");
        Console.WriteLine($"  По батькові: {Name.Lastname}\n");

        Console.WriteLine("— Адреса:");
        Console.WriteLine($"  Країна: {Address.Country}");
        Console.WriteLine($"  Регіон: {Address.Region}");
        Console.WriteLine($"  Місто: {Address.City}");
        Console.WriteLine($"  Вулиця: {Address.Street}");
        Console.WriteLine($"  Будинок: {Address.HouseNumber}");
        Console.WriteLine($"  Поштовий індекс: {Address.PostalCode}\n");

        Console.WriteLine("— Дата народження:");
        Console.WriteLine($"  {Birth.BirthDate:dd.MM.yyyy}\n");

        Console.WriteLine("— Інформація про період навчання:");
        Console.WriteLine($"  Дата початку навчання: {StudyPeriod.StartDate:dd.MM.yyyy}\n");

        Console.WriteLine("— Інформація про курс");
        Console.WriteLine($"  Курс: {KursInfo.Kurs}");
        Console.WriteLine($"  Спеціалізація: {KursInfo.Specialization}");

        Console.WriteLine("— Інформація про групу:");
        Console.WriteLine($"  Група: {GroupInfo.GroupName}");
        Console.WriteLine($"  Кількість студентів у групі: {GroupInfo.StudentsCount}\n");

        Console.WriteLine("— Відвідуваність:");
        Console.WriteLine($"  Відвідано занять: {Attendance.LessonsVisited}");
        Console.WriteLine($"  Запізнень: {Attendance.LessonsLate}\n");

        Console.WriteLine("— Предмет:");
        Console.WriteLine($"  Предмет: {Subject.SubjectName}\n");

        Console.WriteLine("— Викладач:");
        Console.WriteLine($"  Викладач: {Teacher.FirstName} {Teacher.Surname} {Teacher.Lastname}\n");

        
        Grades.PrintAverages();
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Student student = new Student();

        //---------------------------------------
        student.Name.FirstName = "Іван";
        student.Name.Surname = "Петренко";
        student.Name.Lastname = "Олександрович";
        //--------------
        student.Address.Country = "Україна";
        student.Address.Region = "Київська область";
        student.Address.City = "Київ";
        student.Address.Street = "Хрещатик";
        student.Address.HouseNumber = 10;
        student.Address.PostalCode = 12345;
        //--------------
        student.Birth.BirthDate = new DateTime(2002, 6, 15);
        //--------------
        student.StudyPeriod.StartDate = new DateTime(2020, 9, 1);
        //--------------
        student.KursInfo.Kurs = 2;
        student.KursInfo.Specialization = "Програмування";
        //--------------
        student.GroupInfo.GroupName = "CS-22";
        student.GroupInfo.StudentsCount = 28;
        //--------------
        student.Attendance.LessonsVisited = 42;
        student.Attendance.LessonsLate = 3;
        //--------------
        student.Subject.SubjectName = "Алгоритми і Структури Даних";
        //--------------
        student.Teacher.FirstName = "Олег";
        student.Teacher.Surname = "Павленко";
        student.Teacher.Lastname = "Олександрович";
        //--------------
        student.Grades.DzRates.AddRange(new int[] { 10, 11, 12 });
        student.Grades.PracticeRates.AddRange(new int[] { 9, 10, 12 });
        student.Grades.ExamRates.AddRange(new int[] { 12 });
        student.Grades.ZachetRates.AddRange(new int[] { 10, 10, 11 });
        //-------------------
        student.PrintInfo();
    }
}