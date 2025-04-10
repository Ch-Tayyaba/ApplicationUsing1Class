using ScholarshipSystem.BL;
using ScholarshipSystem.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.DL
{   
    public class UserDL
    {
        private static List<UserBL> user = new List<UserBL>();
        //public static void loadFrame()
        //{
        //    string path = @"F:\2nd Semester\OOP\BussinessApplication\frame.txt";
        //    UserBL.frame = new char[34, 145];
        //    StreamReader f = new StreamReader(path);
        //    string record;
        //    for (int row = 0; row < 34; row++)
        //    {
        //        record = f.ReadLine();
        //        for (int col = 0; col < 145; col++)
        //        {
        //            char value = record[col];
        //            UserBL.frame[row, col] = value;
        //        }
        //    }
        //}
        public static bool addToList(UserBL u)
        {
            user.Add(u);
            return true;
        }
        //public static void viewList()
        //{
        //    foreach(UserBL u in user)
        //    {
        //        Console.WriteLine(u.getUsername() + "   " + u.getPassword());
        //    }
        //}
        public static List<UserBL> getList()
        {
            return user;
        }
        public static bool isUserExist(UserBL u)
        {
            for (int idx = 0; idx < user.Count; idx++)
            {
                if (u.getUsername() == user[idx].getUsername() && u.getPassword() == user[idx].getPassword())
                {
                    return true;
                }
            }
            Console.ReadKey();
            return false;
        }
        public static User typeOfUser(UserBL loginUser)
        {
            foreach(UserBL u in user)
            {
               
                if (u.getUsername() == loginUser.getUsername() && u.getPassword() == loginUser.getPassword())
                {
                    if (u.getRole() == "Admin")
                    {
                        return new Admin();
                    }

                    if (u.getRole() == "NeedBaseTaker")
                    {
                        return new NeedBaseTaker();
                    }
                    else if (u.getRole() == "MeedBaseTaker")
                    {
                        return new MeritBaseTaker();
                    }
                }
            }
            return null;
        }
        public static string getCurreuntRole(UserBL u)
        {
            for (int idx = 0; idx < user.Count; idx++)
            {
                if (u.getUsername() == user[idx].getUsername() && u.getPassword() == user[idx].getPassword())
                {
                    return user[idx].getRole();
                }
            }
            return null;
        }
        public static string getRoleByName(string name)
        {
            for (int idx = 0; idx < user.Count; idx++)
            {
                if (name == user[idx].getUsername())
                {
                    return user[idx].getRole();
                }
            }
            return null;
        }
        public static void removeTaker(string userName)
        {
            for (int idx = 0; idx < user.Count; idx++)
            {
                if (userName == user[idx].getUsername())
                {
                    user.RemoveAt(idx);
                }
            }
        }

    }
}
