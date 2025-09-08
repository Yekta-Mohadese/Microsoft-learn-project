using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalDraft
{
   
            
class Program
        {
        static void Main()
        {

            List<string> studentNames = new List<string>();
            List<int> studentIDs = new List<int>();
            List<double> studentAverages = new List<double>();

            while (true)
            {


                Console.WriteLine("chose one option:   Add student:1     View students list:2    Exit:3");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent(studentNames, studentIDs, studentAverages);
                        break;
                    case 2:
                        ViewStudents(studentNames, studentIDs, studentAverages);
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
                static void AddStudent(List<string> studentNames, List<int> studentIDs, List<double> studentAverages)
                {
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();


                    Console.Write($"Enter ID for {name}: ");
                    int id = int.Parse(Console.ReadLine());


                    Console.WriteLine($"Enter scores for {name} first Math, second Science, third History and the final one Art:");
                    Console.Write("Math: ");
                    double math = double.Parse(Console.ReadLine());

                    Console.Write("Science: ");
                    double science = double.Parse(Console.ReadLine());

                    Console.Write("History: ");
                    double history = double.Parse(Console.ReadLine());

                    Console.Write("Art: ");
                    double art = double.Parse(Console.ReadLine());

                    // Calculate average
                    double average = CalculateAverage(math, science, history, art);

                studentNames.Add(name);
                    studentIDs.Add(id);
                    studentAverages.Add(average);

                    Console.WriteLine($"{name}'s average score: {average}");
                }
                static void ViewStudents(List<string> studentNames, List<int> studentIDs, List<double> studentAverages)
              {
                // Display all students
                Console.WriteLine("Student List: ");
            if (studentNames == null || studentNames.Count == 0 )
                { 
                Console.WriteLine("No students have been added yet.");
                return;
                }

            for (int i = 0; i < studentNames.Count; i++)
                {
                    Console.WriteLine($"Name: {studentNames[i]}, ID: {studentIDs[i]}, Average: {studentAverages[i]}");
                }
              }
            
                static double CalculateAverage(double math, double science, double history, double art)
                {
                    return (math + science + history + art) / 4;
                }
    }
    }
    