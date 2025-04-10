using ScholarshipSystem.BL;
using ScholarshipSystem.DL;
using ScholarshipSystem.Driver;
using ScholarshipSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            UserBL user;
            Console.ReadKey();
            AdminDL.defineAdmin();
            //User.printFrame();
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                option = User.mainMenu();
                if (option == 1)
                {
                    User.signUp();
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    bool flag = true;
                    user = UserUI.signInMenu();
                    User u = User.signIn(user);
                    while (flag)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        
                        option = u.menu();
                        if (option == 1)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.add(user);
                        }
                        else if (option == 2)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.removeOrUpdate(user);
                        }
                        else if (option == 3)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.view(user);
                        }
                        else if (option == 4)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.option04(user);
                        }
                        else if (option == 5)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.option05(user);
                        }
                        else if (option == 6)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.option06(user);
                        }
                        else if (option == 7)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.option07(user);
                        }
                        else if (option == 8)
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.option08(user);
                        }
                        else if (option == 9 )
                        {
                            Console.ReadKey();
                            Console.Clear();
                            u.feedBacks(user);
                        }
                        else if(option == 9 || option == 0)
                        {
                            flag = false;
                        }
                    }
                }
            }
        }
    }
}
