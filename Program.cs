
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace UniManagementSystem
{
    class Program
    {
        private static Rootobject StudentsObject = new Rootobject();
        public static void Main()
        {
            StudentsObject = JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText("C:\\Users\\simna\\Documents\\TechTest\\UniManagementSystem\\students.json"));
            //reads student.JSON ands stores all the student data into a series of Objects.

            Console.WriteLine("Welcome to the University Management System");
            Console.WriteLine("If you would like to view Student records, please type 1");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    ViewStudentRecord();
                    break;
            }
        }
        private static void ViewStudentRecord()
        {
            int NumOfStudents = 0;
            int count = 0;
            bool finished = false;

            Console.WriteLine("How many students would you like to search for?");
            NumOfStudents = Convert.ToInt32(Console.ReadLine());
            count = NumOfStudents;

            if (NumOfStudents > StudentsObject.students.Length)
            {
                Console.WriteLine("There are not that many students in the list. you can choose up to " + StudentsObject.students.Length + " students to view.\n");
                return;
            }
            //Validation makes sure that the user cannot enter a number larger than the number of student objects.
            while (count > 0)
            {
                Console.WriteLine("\nPlease write the name of one of the following students");
                for (int i = 0; i < StudentsObject.students.Length; i++)
                {
                    Console.WriteLine(StudentsObject.students[i].name);
                }

                string NameOfStudent = Console.ReadLine();

                    for (int i = 0; i < StudentsObject.students.Length; i++)
                    {
                        if (NameOfStudent == StudentsObject.students[i].name)
                        {
                        Console.WriteLine("\nHere is the record for " + StudentsObject.students[i].name + ".");
                        Console.WriteLine("University: " + StudentsObject.students[i].university);
                        Console.WriteLine("Major: " + StudentsObject.students[i].major);
                        Console.WriteLine("Student ID: " + StudentsObject.students[i].student_id);
                        //Each block of code here outputs one of the subjects of a student along with the results
                        Console.WriteLine("Subject 1: " + StudentsObject.students[i].grades.subjects[0].name);
                        Console.WriteLine("Score: " + StudentsObject.students[i].grades.subjects[0].score);
                        Console.WriteLine("Attendance: " + StudentsObject.students[i].attendance.subjects[0].score);

                        Console.WriteLine("Subject 2: " + StudentsObject.students[i].grades.subjects[1].name);
                        Console.WriteLine("Score: " + StudentsObject.students[i].grades.subjects[1].score);
                        Console.WriteLine("Attendance: " + StudentsObject.students[i].attendance.subjects[1].score);
                        
                        Console.WriteLine("Subject 3: " + StudentsObject.students[i].grades.subjects[2].name);
                        Console.WriteLine("Score: " + StudentsObject.students[i].grades.subjects[2].score);
                        Console.WriteLine("Attendance: " + StudentsObject.students[i].attendance.subjects[2].score);

                        Console.WriteLine("Subject 4: " + StudentsObject.students[i].grades.subjects[3].name);
                        Console.WriteLine("Score: " + StudentsObject.students[i].grades.subjects[3].score);
                        Console.WriteLine("Attendance: " + StudentsObject.students[i].attendance.subjects[3].score);

                        Console.WriteLine("Subject 5: " + StudentsObject.students[i].grades.subjects[4].name);
                        Console.WriteLine("Score: " + StudentsObject.students[i].grades.subjects[4].score);
                        Console.WriteLine("Attendance: " + StudentsObject.students[i].attendance.subjects[4].score);

                        
                        count--;
                        }
                    }

                }
        }
    }
}