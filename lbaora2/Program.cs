using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lbaora2

{
    
    public class Student
    {
        private string namestudent;
        private int id;
        /*private DateTime date;
        private string institute;
        private string group;
        private string course;
        private float avgmark;*/

        public Student()
        {
        }

        public Student(string Namestudent, int Id)//, DateTime Date, string Institute, string Group, string Course, float Avgmark)
        {
            id = Id;
            namestudent = Namestudent;
            /*Date = date;
            institute = Institute;
            Group = group;
            Course = course;
            Avgmark = avgmark;*/


        }
        public string Namestudent
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

    }
    public static class Data
    {
        public static Student[] students = new Student[2];
       
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data.students[0] = new Student("Vanya", 21);
            Data.students[1] = new Student("fedya", 31);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


           
             

           
        }
    }
}
