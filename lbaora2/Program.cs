﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Web;
using System.Drawing.Text;
using System.Runtime.InteropServices.WindowsRuntime;

namespace lbaora2

{
    public class Human
    {
        public string name { get; set; }
        public DateTime date { get; set; }

        public Human(string Name, DateTime Date)
        {
            this.name = name;
            this.date = date;
        }

    }
  
    public class Student:Human
    {
        private int id;
        private string institute;
        private string group;
        private string course;
        private double avgmark;
        
 
        
       
        
        public Student(string Name , int Id,DateTime Date,  string Institute, string Group, string Course, double Avgmark): base(Name,Date)
        {
            id = Id;
            institute = Institute;
            group = Group;
            course = Course;
            avgmark = Avgmark;
            date = Date;
            name = Name;
           

        }
        
        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        
        public string Institute
        { 
            get
            { 
                return institute; 
            } set 
            {
                institute = value; 
            }
        }
        public string Group
        {
            get
            {
                return group;
            }
            set 
            {
                group = value; 
            }
        }
        public string Course
        {
            get
            {
                return course;

            }
            set
            {
                course = value;
            }
        }
        public double Avgmark
        {
            get
            {
                return avgmark;

            }
            set
            {
                avgmark = value;
            }
        }
    }

    
    
    public static class Data
    {
        public static List<Student> students = new List<Student>();
        public static string filter = "";
        public static List<Student> filteredStudents = new List<Student>() ;
        public static string filename = "students.json";
        public static Student voidstudent = new Student(" ",00 ,new DateTime(1900,01,01) ," ",""," ", 0.0) ;
        public static void ApplyFilter()
        {
            filteredStudents = new List<Student>();
            foreach (Student student in students)
            {

                if( student.name.Contains(filter)|| filter=="")
                {
                    filteredStudents.Add(student);
                } 
            }
        }

        public static void Load()
        {
         //Читаем студентов из файла
         string json=File.ReadAllText(filename);
         students = JsonSerializer.Deserialize<List<Student>>(json);
        }

        public static void Save()
        {
            //Сохраняем студентов в файл
            string json = JsonSerializer.Serialize(students);
            File.WriteAllText(filename,json);
        }
        public static void New()
        {
            students.Add(new Student("", 00, new DateTime(1900, 01, 01), "Иткн", "БИВТ-22-10", "1", 0.0));
        }
        public static void Delete(Student target)
        {
            students.Remove(target);
        }
    }




    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

           // Data.students.Add( new Student("Vanya", 21, new DateTime(2004,11,13)  ,"Иткн","БИВТ-22-10","1", 4.3));
           // Data.students.Add( new Student("Vanya", 22, new DateTime(2004, 11, 13), "Иткн", "десятая", "четвертый", 4.3));
           //Data.students.Add(new Student("fedya", 31, new DateTime(2004, 11, 03), "Иткн", "десятая", "четвертый", 4.3));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Data.ApplyFilter();
            Application.Run(new Form1());
           
             

           
        }
    }
}
