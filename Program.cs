﻿using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        List<Student> studentList = new List<Student>() 
        {
                new Student() { StudentID = 1, StudentName = "John" } ,
                new Student() { StudentID = 2, StudentName = "Moin" } ,
                new Student() { StudentID = 3, StudentName = "Bill" } ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron"  }
        };

        // upit i izvršavanje upita

    var res = studentList.Where(s => s.Contains("n"));

    }
    public class Student
    {

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    }





}



