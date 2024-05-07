using System;

class Course
{
    public string _courseCode;
    public string _courseName;
    public int _credit;
    public string _color;

    // method
    public void Display() {
        Console.WriteLine($"{_courseCode} {_courseName} {_credit} {_color}");
    }
}