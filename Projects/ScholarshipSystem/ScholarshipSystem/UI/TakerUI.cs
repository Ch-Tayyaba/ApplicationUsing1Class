using ScholarshipSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.UI
{
    public class TakerUI
    {
        public static int menu()
        {
            Console.WriteLine("1. Add Information.");
            Console.WriteLine("2. Update Information.");
            Console.WriteLine("3. View your Information.");
            Console.WriteLine("4. View your Eligibility.");
            Console.WriteLine("5. Get Scholarship.");
            Console.WriteLine("6. View Scholarship Record.");
            Console.WriteLine("7. Give FeedBacks.");
            Console.WriteLine("8. Update FeedBacks.");
            Console.WriteLine("9. View FeedBacks.");
            Console.WriteLine("10. Exit.");
            Console.Write(" Enter Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static string takeName()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static string takeCNIC()
        {
            Console.Write("Enter CNIC: ");
            string CNIC = Console.ReadLine();
            return CNIC;
        }
        public static string takeFatherName()
        {
            Console.Write("Enter Father Name: ");
            string fatherName = Console.ReadLine();
            return fatherName;
        }
        public static float takeFee()
        {
            Console.Write("Enter Per Month Fee: ");
            float fee = float.Parse(Console.ReadLine());
            return fee;
        }
        public static void viewSCRecord(ScholarshipBL record)
        {
            Console.WriteLine("Scholarship\t\t\tDate");
            Console.WriteLine(record.getScholarship() + "\t\t\t" + record.getDate());
        }
        public static void printEligible(string logo)
        {
            Console.WriteLine("You are " + logo + " For our Scholarship");
        }
        public static void printGetScholarship(string logo)
        {

            Console.WriteLine("You " + logo + " got Scholarship.");
        }

    }
}
