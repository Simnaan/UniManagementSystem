using System;
public class Rootobject
{
    public Student[] students { get; set; }
}

public class Student
{
    public string name { get; set; }
    public string university { get; set; }
    public string major { get; set; }
    public string student_id { get; set; }
    public Grades grades { get; set; }
    public Attendance attendance { get; set; }
}

public class Grades
{
    public Subject[] subjects { get; set; }
}

public class Subject
{
    public string name { get; set; }
    public int score { get; set; }
}

public class Attendance
{
    public Subject1[] subjects { get; set; }
}

public class Subject1
{
    public string name { get; set; }
    public int score { get; set; }
}

