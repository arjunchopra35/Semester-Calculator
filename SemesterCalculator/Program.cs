/* Author: ARJUN CHOPRA
 * Date" September 10 2018
 * Program Name: ICE 01 Student Information
 * Program Description: Program that prompts and displays student information
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string name;
            string course;
            int courseDuration;
            int courseSemester;
            int semesterToCompletion;
            
           



            // Program title displayed at top
            Console.Title = "ICE 01";

            //Prompting for student name 
            Console.WriteLine("Please Enter Your Name?");
            name = Console.ReadLine();

            //Prompting for student course 
            Console.WriteLine("Please Enter Your Course?");
            course = Console.ReadLine();

            //Prompting for Course Duration 
            Console.WriteLine("Please Enter Your Course Duration?");
            courseDuration = int.Parse(Console.ReadLine());

            //Prompting for Course Semester
            Console.WriteLine("Please Enter Your Current Semester?");
            courseSemester = int.Parse(Console.ReadLine());

            semesterToCompletion = courseDuration - courseSemester;

            // Clear the console window
            Console.Clear();

            // Displaying student information 

            Console.WriteLine("Student Name" + name);
            
            Console.WriteLine("Student Course" + course);
            
            Console.WriteLine("Total duration of the course" + courseDuration);
            
            Console.WriteLine("Current semester of the student" + courseSemester);
            
            Console.WriteLine("Total semester left" + semesterToCompletion);

            //Prompt for exit 
            Console.WriteLine("Press any key to exit ");

            // Waiting for any key to be pressed
            Console.ReadKey();

        }
    }
}
