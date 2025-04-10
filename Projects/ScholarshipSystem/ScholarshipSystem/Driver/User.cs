using ScholarshipSystem.BL;
using ScholarshipSystem.DL;
using ScholarshipSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.Driver
{
    public class User
    {
        //public static void printFrame()
        //{
        //    UserDL.loadFrame();
        //    UserUI.printFrame();
        //    UserUI.printHello();
        //}
        public static int mainMenu()
        {
            int option = UserUI.mainMenu();
            return option;
        }
        public static void signUp()
        {
            UserBL u = UserUI.signUpMenu();
            if (u.getRole() == "MeritBaseTaker")
            {
                UserDL.addToList(u);
                MeritBaseTakerBL n = new MeritBaseTakerBL(u.getUsername(), u.getPassword());
                bool flag = MeritBaseTakerDL.addToList(n);
                if (flag) { UserUI.done(); }
            }
            else if (u.getRole() == "NeedBaseTaker")
            {
                UserDL.addToList(u);
                NeedBaseTakerBL m = new NeedBaseTakerBL(u.getUsername(), u.getPassword());
                bool flag = NeedBaseTakerDL.addToList(m);
                if (flag) { UserUI.done(); }
            }
            else
            {
                UserUI.again();
            }
        }
        public static bool userExist(UserBL u)
        {
            bool flag = UserDL.isUserExist(u);
            if(flag)
            {
                return true;
            }
            else
            {
                UserUI.again();
                return false;
            }
        }
        public static User signIn(UserBL u)
        {
            UserBL user = u;
            bool f = true;
            while(f)
            {
                bool flag = UserDL.isUserExist(user);
                if (flag)
                {
                    User a = UserDL.typeOfUser(user);
                    return a;
                    f = false;
                }
                else
                {
                    UserUI.again();
                    user = UserUI.signInMenu();
                }
            }
            return null;
                
        }
        public virtual int menu()
        {
            return 0;
        }
        public virtual void add(UserBL user)
        {

        }
        public virtual void removeOrUpdate(UserBL user)
        {
        }
        public virtual void view(UserBL user)
        {

        }
        public virtual void option04(UserBL user)
        {

        }
        public virtual void option05(UserBL user)
        {

        }
        public virtual void option06(UserBL user)
        {

        }
        public virtual void option07(UserBL user)
        {

        }
        public virtual void option08(UserBL user)
        {

        }
        public virtual void feedBacks(UserBL user)
        {

        }
    }
}
