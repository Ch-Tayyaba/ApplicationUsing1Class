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
    public class Admin : User
    {
        public override int menu()
        {
            int option = AdminUI.menu();
            return option;
        }
        public override void add(UserBL user)
        {
            User.signUp();
        }
        public override void removeOrUpdate(UserBL user)
        {
            string name = AdminUI.takeName();
            UserDL.removeTaker(name);
            string role = UserDL.getCurreuntRole(user);
            if(role == "NeedBase Taker")
            {
                bool flag = NeedBaseTakerDL.removeTaker(user);
                if(flag)
                {
                    UserUI.done();
                }
            }
            else if(role == "MeritBase Taker")
            {
                bool flag = MeritBaseTakerDL.removeTaker(user);
                if(flag)
                {
                    UserUI.done();
                }
            }

        }
        public static void viewMB()
        {
            AdminUI.viewforMeritBase("MeritBase Taker");
            List<MeritBaseTakerBL> MB = MeritBaseTakerDL.getList();
            for (int idx = 0; idx < MB.Count; idx++)
            {
                AdminUI.viewMB(MB[idx]);
            }
        }
        public static void viewNB()
        {
            AdminUI.viewforNeedBase("NeedBase Taker");
            List<NeedBaseTakerBL> NB = NeedBaseTakerDL.getList();
            for (int idx = 0; idx < NB.Count; idx++)
            {
                AdminUI.viewNB(NB[idx]);
            }
        }
        public override void view(UserBL user)
        {
            viewMB();
            Console.Clear();
            //User.printFrame("");
            Console.ReadKey();
            viewNB();
            Console.ReadKey();

        }
        public override void option04(UserBL user)
        {
            string name = AdminUI.takeName();
            string role = UserDL.getRoleByName(name);
            if(role == "NeedBaseTaker")
            {
                AdminUI.viewforNeedBase(" ");
                List<NeedBaseTakerBL> NB = NeedBaseTakerDL.getList();
                for (int idx = 0; idx < NB.Count; idx++)
                {
                    if (name == NB[idx].getUsername())
                    {
                        AdminUI.viewNB(NB[idx]);
                    }
                }
            }
            else if(role == "MeritfBaseTaker")
            {
                List<MeritBaseTakerBL> MB = MeritBaseTakerDL.getList();
                for (int idx = 0; idx < MB.Count; idx++)
                {
                    if (name == MB[idx].getUsername())
                    {
                        AdminUI.viewMB(MB[idx]);
                    }
                }
            }
            else
            {
                UserUI.again();
            }
        }
        public override void option05(UserBL user)
        {
            double amount = AdminUI.takeAmount();
            bool flag = AdminDL.setDonationAmount(amount);
            if(flag)
            {
                UserUI.done();
            }
            else
            {
                UserUI.again();
            }
        }
        public override void option06(UserBL user)
        {
            double donation = AdminDL.getDonationAmount();
            double donated = AdminDL.getDonationAmount();
            AdminUI.viewAmount("Donation", donation);
            AdminUI.viewAmount("Donated", donated);
        }
        public override void option07(UserBL user)
        {
            int stages = AdminUI.takeStages();
            for(int idx = 0; idx < stages; idx++)
            {
                float income = AdminUI.takeInput("income");
                float scholarship = AdminUI.takeInput("scholarship");
                NeedBaseScholarshipBL NB = new NeedBaseScholarshipBL();
                NB.setIncome(income);
                NB.setScholarship(scholarship);
                AdminDL.addToNBList(NB);
            }
            AdminDL.throwNBToAdmin();
        }
        public override void option08(UserBL user)
        {
            int stages = AdminUI.takeStages();
            for (int idx = 0; idx < stages; idx++)
            {
                float percentage = AdminUI.takeInput("Percentage");
                float scholarship = AdminUI.takeInput("scholarship");
                MeritBaseScholarshipBL MB = new MeritBaseScholarshipBL();
                MB.setPercentage(percentage);
                MB.setScholarship(scholarship);
                AdminDL.addToMBList(MB);
            }
            AdminDL.throwMBToAdmin();
        }
        public override void feedBacks(UserBL user)
        {
            List<NeedBaseTakerBL> NB = NeedBaseTakerDL.getList();
            List<MeritBaseTakerBL> MB = MeritBaseTakerDL.getList();
            for(int idx = 0; idx < NB.Count; idx++)
            {
                AdminUI.viewLogo("For NeedBase Taker");
                UserUI.viewFeedBacks(NB[idx].getFeedbacks());
            }
            for (int idx = 0; idx < MB.Count; idx++)
            {
                AdminUI.viewLogo("For MeritBase Taker");
                UserUI.viewFeedBacks(MB[idx].getFeedbacks());
            }

        }

    }
}
