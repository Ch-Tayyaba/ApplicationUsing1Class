using ScholarshipSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.UI
{
    public class UserUI
    {
        public static void printFrame()
        {
            Console.Clear();
            for (int row = 0; row < 34; row++)
            {
                Console.WriteLine();
                for (int col = 0; col < 145; col++)
                {
                    Console.Write(UserBL.frame[row, col]);
                }
            }
        }
        public static void printHello()
        {
            Console.WriteLine("Helo!");
        }
        public static void done()
        {
            Console.WriteLine("Successfully Done!");
            Console.ReadKey();
        }

        public static void again()
        {
            Console.WriteLine("Try Again!");
            Console.ReadKey();
        }
        public static int mainMenu()
        {
            Console.WriteLine("You want to:");
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. SignIn");
            Console.Write("Enter Option : ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static UserBL signUpMenu()
        {
            Console.Write("Enter UserName: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Role: ");
            string role = Console.ReadLine();
            UserBL u = new UserBL(name, password, role); 
            return u;
        }
        public static UserBL signInMenu()
        {
            Console.Write("Enter UserName: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            UserBL u = new UserBL(name, password);
            return u;
        }
        public static void viewFeedBacks(string feedBack)
        {
            Console.WriteLine("=> " + feedBack);
        }
    }
}
