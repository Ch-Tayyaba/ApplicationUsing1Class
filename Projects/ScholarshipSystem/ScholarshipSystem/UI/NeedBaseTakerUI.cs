using ScholarshipSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.UI
{
    public class NeedBaseTakerUI
    {
        public static string takeInput(string logo)
        {
            Console.Write("Enter " + logo + ": ");
            string input = Console.ReadLine();
            return input;
        }
        public static float takeIncome()
        {
            Console.Write("Enter Income:");
            float income = float.Parse(Console.ReadLine());
            return income;
        }
        
        
    }
}
