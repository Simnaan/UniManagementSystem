
using Newtonsoft.Json;
using System.Linq.Expressions;

static void main()
{
    Console.WriteLine("Welcome to the University Management System");
    Console.WriteLine("If you would like to view Student records, please type 1");
    int Option = Convert.ToInt32(Console.ReadLine());

    switch (Option)
    {
        case 1: ViewStudentRecord();
            break;
    }
}

static void ViewStudentRecord()
{

}


// var o = JsonConvert.DeserializeObject<Student>(System.IO.File.ReadAllText(@"c:\students.json"))