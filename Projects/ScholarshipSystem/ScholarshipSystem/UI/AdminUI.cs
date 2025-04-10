using ScholarshipSystem.BL;
using ScholarshipSystem.DL;
using ScholarshipSystem.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.UI
{
    public class AdminUI
    {
        public static int menu()
        {
            Console.WriteLine("1. Add Taker.");
            Console.WriteLine("2. Remove Taker.");
            Console.WriteLine("3. View all Takers.");
            Console.WriteLine("4. Search any Taker.");
            Console.WriteLine("5. Set Donation Amount.");
            Console.WriteLine("6. View Donation Amount.");
            Console.WriteLine("7. Set ScholarShip for NeedBase.");
            Console.WriteLine("8. Set ScholarShip for MeritBase.");
            Console.WriteLine("9. View FeedBacks.");
            Console.WriteLine("10. Exit.");
            Console.Write(" Enter Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static string takeName()
        {
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            return name;
        }
        public static void viewforMeritBase(string logo)
        {
            Console.WriteLine(logo);
            Console.WriteLine();
            Console.WriteLine("Name\t\tCNIC\t\t\tFatherName\t\tFee\t\tDegreeName\t\tTotalMarks\t\tObtMarks");
        }
        public static void viewforNeedBase(string logo)
        {
            Console.WriteLine(logo);
            Console.WriteLine();
            Console.WriteLine("Name\t\tCNIC\t\t\tFatherName\t\tFee\t\tDesignation\t\tIncome");
        }
        public static void viewMB(MeritBaseTakerBL u)
        {
            Console.WriteLine(u.getName() + "\t\t" + u.getCNIC() + "\t\t" + u.getFatherName() + "\t\t" + u.getfee() + "\t\t" + u.getdegree() + "\t\t" + u.getTotalMarks() + "\t\t" + u.getObtMarks());
        }
        public static void viewNB(NeedBaseTakerBL u)
        {
            Console.WriteLine(u.getName() + "\t\t" + u.getCNIC() + "\t\t" + u.getFatherName() + "\t\t" + u.getfee() + "\t\t" + u.getDesignation() + "\t\t" + u.getIncome());
        }
        public static double takeAmount()
        {
            Console.Write("Enter Donation Amount: ");
            double amount = double.Parse(Console.ReadLine());
            return amount;
        }
        public static void viewAmount(string type, double amount)
        {
            Console.WriteLine("Your " + type + " amount is: " + amount);
        }
        public static int takeStages()
        {
            Console.Write("Enter stages you want to add up to: ");
            int stages = int.Parse(Console.ReadLine());
            return stages;
        }
        public static float takeInput(string logo)
        {
            Console.Write("Enter " + logo + ": ");
            float input = float.Parse(Console.ReadLine());
            return input;
        }
        public static void viewLogo(string logo)
        {
            Console.WriteLine(logo);
            Console.WriteLine();
        }
    }
}
