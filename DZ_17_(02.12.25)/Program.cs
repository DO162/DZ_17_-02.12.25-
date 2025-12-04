/*використовуючи принцип SRP, розбити клас Student на 5+ дрібніших типів (не забуваючи про зв'язки між класами)

class Student
{
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public string? Lastname { get; set; }

    public string? Country { get; set; }
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public int HouseNumber { get; set; }
    public char Korpus { get; set; }
    public short PostalCode { get; set; }

    public int BirthDay { get; set; }
    public int BirthMonth { get; set; }
    public int BirthYear { get; set; }

    public int StartDay { get; set; }
    public int StartMonth { get; set; }
    public int StartYear { get; set; }

    public int Kurs { get; set; }
    public string? GroupName { get; set; }
    public string? Specialization { get; set; }
    public int StudentsCount { get; set; }

    public int LessonsVisited { get; set; }
    public int LessonsLate { get; set; }

    public string? TeacherName { get; set; }
    public string? SubjectName { get; set; }


    public int[]? DzRates { get; set; }
    public float DzAverageRate { get; set; }
    public int[]? PracticeRates { get; set; }
    public float PracticeAverageRate { get; set; }
    public int[]? ExamRates { get; set; }
    public float ExamAverageRate { get; set; }
    public int[]? ZachetRates { get; set; }
    public int ZachetCount { get; set; }
    public float ZachetAverageRate { get; set; }
    public double TotalAverageRate { get; set; }

}

class Program
{
    static void Main()
    {

    }
}*/

//-------------------------------------------------------------------------------------------------

using System;

// 1️ - Имя студента
class StudentName
{
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public string? Lastname { get; set; }
}

// 2️ - Адреса студента
class Address
{
    public string? Country { get; set; }
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public int HouseNumber { get; set; }
    public char Korpus { get; set; }
    public short PostalCode { get; set; }
}

// 3️ - Інформация про дату родження
class BirthInfo
{
    public int BirthDay { get; set; }
    public int BirthMonth { get; set; }
    public int BirthYear { get; set; }
}

// 4️ - Інформация про обучение
class StudyInfo
{
    public int StartDay { get; set; }
    public int StartMonth { get; set; }
    public int StartYear { get; set; }

    public int Kurs { get; set; }
    public string? GroupName { get; set; }
    public string? Specialization { get; set; }
    public int StudentsCount { get; set; }
}

// 5️ - Посещаемость
class Attendance
{
    public int LessonsVisited { get; set; }
    public int LessonsLate { get; set; }
}

// 6️ - Інформация про предмет
class SubjectInfo
{
    public string? TeacherName { get; set; }
    public string? SubjectName { get; set; }
}

// 7️ - Оценки студента
class Grades
{
    public int[]? DzRates { get; set; }
    public float DzAverageRate { get; set; }
    //-------------
    public int[]? PracticeRates { get; set; }
    public float PracticeAverageRate { get; set; }
    //-------------
    public int[]? ExamRates { get; set; }
    public float ExamAverageRate { get; set; }
    //-------------
    public int[]? ZachetRates { get; set; }
    public int ZachetCount { get; set; }
    public float ZachetAverageRate { get; set; }
    //-------------
    public double TotalAverageRate { get; set; }
}

// Основной класс Student, который использует все вышеперечисленные классы
class Student
{
    public StudentName Name { get; set; }
    public Address Address { get; set; }
    public BirthInfo Birth { get; set; }
    public StudyInfo Study { get; set; }
    public Attendance Attendance { get; set; }
    public Grades Grades { get; set; }
    public SubjectInfo Subject { get; set; }

    public Student()
    {
        Name = new StudentName();
        Address = new Address();
        Birth = new BirthInfo();
        Study = new StudyInfo();
        Attendance = new Attendance();
        Grades = new Grades();
        Subject = new SubjectInfo();
    }
}

class Program
{
    static void Main()
    {
        //-------------------
        Student student = new Student();
        student.Name.FirstName = "Іван";
        student.Name.Surname = "Петренко";
        student.Birth.BirthDay = 15;
        student.Birth.BirthMonth = 6;
        student.Birth.BirthYear = 2002;
        student.Study.Kurs = 2;
        student.Study.GroupName = "CS-22";
        student.Attendance.LessonsVisited = 42;
        student.Attendance.LessonsLate = 3;

        Console.WriteLine($"Студент: {student.Name.FirstName} {student.Name.Surname}, " +
            $"Дата народження: {student.Birth.BirthDay}/{student.Birth.BirthMonth}/{student.Birth.BirthYear}, " +
            $"Курс: {student.Study.Kurs}, " +
            $"Група: {student.Study.GroupName}, " +
            $"Відвідано занять: {student.Attendance.LessonsVisited}, " +
            $"Запізнень: {student.Attendance.LessonsLate}");
    }
}
