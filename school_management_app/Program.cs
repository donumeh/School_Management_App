using System;
using System.Collections.Generic;

class Program
{
    static List<Staff> staffList = new List<Staff>();
    static List<Teacher> teacherList = new List<Teacher>();
    static List<SchoolClass> classList = new List<SchoolClass>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Add Staff");
            Console.WriteLine("2. Add Teacher");
            Console.WriteLine("3. Add School Class");
            Console.WriteLine("4. Print Staffs");
            Console.WriteLine("5. Print Teachers");
            Console.WriteLine("6. Print School Classes");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStaff();
                    break;
                case "2":
                    AddTeacher();
                    break;
                case "3":
                    AddSchoolClass();
                    break;
                case "4":
                    PrintStaffs();
                    break;
                case "5":
                    PrintTeachers();
                    break;
                case "6":
                    PrintSchoolClasses();
                    break;
                case "7":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddStaff()
    {
        Console.WriteLine("Adding Staff...");
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter job description: ");
        string jobDescription = Console.ReadLine();
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Staff staff = new Staff(name, id, jobDescription, salary);
        staffList.Add(staff);

        Console.WriteLine("Staff added successfully.");
    }

    static void AddTeacher()
    {
        Console.WriteLine("Adding Teacher...");
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter job description: ");
        string jobDescription = Console.ReadLine();
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Teacher teacher = new Teacher(name, id, jobDescription, salary);
        teacherList.Add(teacher);

        Console.WriteLine("Teacher added successfully.");
    }

    static void AddSchoolClass()
    {
        Console.WriteLine("Adding School Class...");
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        SchoolClass schoolClass = new SchoolClass(className);
        classList.Add(schoolClass);

        Console.WriteLine("School Class added successfully.");
    }

    static void PrintStaffs()
    {
        Console.WriteLine("Staffs:");
        foreach (var staff in staffList)
        {
            Console.WriteLine($"Name: {staff.GetName()}, ID: {staff.GetId()}, Job Description: {staff.GetJobDescription()}, Salary: {staff.GetSalary()}");
        }
    }

    static void PrintTeachers()
    {
        Console.WriteLine("Teachers:");
        foreach (var teacher in teacherList)
        {
            Console.WriteLine($"Name: {teacher.GetName()}, ID: {teacher.GetId()}, Job Description: {teacher.GetJobDescription()}, Salary: {teacher.GetSalary()}");
            if (teacher.GetClassName() != null)
            {
                Console.WriteLine($"Class Name: {teacher.GetClassName().GetClassName()}");
            }
        }
    }

    static void PrintSchoolClasses()
    {
        Console.WriteLine("School Classes:");
        foreach (var schoolClass in classList)
        {
            Console.WriteLine($"Class Name: {schoolClass.GetClassName()}");
            if (schoolClass.GetClassTeacher() != null)
            {
                Console.WriteLine($"Class Teacher: {schoolClass.GetClassTeacher().GetName()}");
            }
        }
    }
}

