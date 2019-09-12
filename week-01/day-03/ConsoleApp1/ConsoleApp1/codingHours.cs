using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int averageDailyCodeHours = 6;
            int averageWeeklyCodeHours = averageDailyCodeHours * 5; //30 
            int semesters = 17;
            int semesterHours = 52 * 17;
            int codeHoursPerSemester = averageWeeklyCodeHours * semesters;
            int percentageWeeklyCodeHours = averageWeeklyCodeHours * semesters;

            Console.WriteLine("Hours:" + (percentageWeeklyCodeHours));
            Console.WriteLine("Percentage of coding hours in semester: " + Math.Round((codeHoursPerSemester/((double)semesterHours)* 100)) + "%");
            Console.ReadLine();
        }
    }
}


// An average Green Fox attendee codes 6 hours daily 
// The semester is 17 weeks long
//
// Print how many hours is spent with coding in a semester by an attendee,  6*5 = 30 hodin týdně
// if the attendee only codes on workdays.                                  30*17 = 510 hodin kodovani za semestr
//
// Print the percentage of the coding hours in the semester if the average  
// work hours weekly is 52                                                  52*17 = 884 hodin za semestr celkem
//                                                                          510/884 = 0,576