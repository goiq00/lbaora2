using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lbaora2

{
    
    public class Student
    {
        public string namestudent;
        private int id;
        private DateTime date;
        private string institute;
        private string group;
        private string course;
        private double avgmark;
       
        public Student()
        {
        }
        
        public Student(string StudentName, int Id, DateTime Date, string Institute, string Group, string Course, double Avgmark)
        {
            id = Id;
            namestudent = StudentName;
            date = Date;
            institute = Institute;
            group = Group;
            course = Course;
            avgmark = Avgmark;
            
            
           

        }
        
        public string Name
        {
            get
            {
                return namestudent;
            }
            set
            {
                namestudent = value;
            }
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
        public DateTime Date
        {
            get
            {
                return date;

            }
            set 
            {
                date = value;
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
        public static Student[] students = new Student[3];
        public static string filter = "";
        public static List<Student> filteredStudents = new List<Student>() ;
        public static void ApplyFilter()
        {
            filteredStudents = new List<Student>();
            foreach (Student student in students)
            {

                if( student.namestudent.Contains(filter)|| filter=="")
                {
                    filteredStudents.Add(student);
                } 
            }
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

            Data.students[0] = new Student("Vanya", 21, new DateTime(2004,11,13)  ,"Иткн","десятая","четвертый", 4.3);
            Data.students[1] = new Student("Vanya", 22, new DateTime(2004, 11, 13), "Иткн", "десятая", "четвертый", 4.3);
            Data.students[2] = new Student("fedya", 31, new DateTime(2004, 11, 03), "Иткн", "десятая", "четвертый", 4.3);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data.ApplyFilter();
            Application.Run(new Form1());
           
             

           
        }
    }
}
