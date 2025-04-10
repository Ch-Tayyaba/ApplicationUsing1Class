using ScholarshipSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.UI
{
    public class MeritBaseTakerUI
    { 
        public static string takeDegree()
        {
            Console.Write("Enter Degree Name: ");
            string degree = Console.ReadLine();
            return degree;
        }
        public static float takeTotalMarks()
        {
            Console.Write("Enter Total Marks:");
            float totalMarks = float.Parse(Console.ReadLine());
            return totalMarks;
        }
        public static float takeObtMarks()
        {

            Console.Write("Enter Obtained Marks:");
            float obtMarks = float.Parse(Console.ReadLine());
            return obtMarks;
        }
        public static string takeInput(string logo)
        {

            Console.Write("Enter " + logo + ": ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
