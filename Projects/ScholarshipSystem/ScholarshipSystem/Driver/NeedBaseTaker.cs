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
    public class NeedBaseTaker : Taker
    {
        public override void add(UserBL user)
        {
            TakerBL info = Taker.takeInput();
            string designation = NeedBaseTakerUI.takeInput("designation ");
            float income = NeedBaseTakerUI.takeIncome();
            NeedBaseTakerBL data = new NeedBaseTakerBL(info.getName(), info.getCNIC(), info.getFatherName(), info.getfee(), designation, income);
            bool flag = NeedBaseTakerDL.addToList(user, data);
            if(flag)
            {
                UserUI.done();
            }
        }
        public override void removeOrUpdate(UserBL user)
        {
            add(user);
        }
        public override void view(UserBL user)
        {
            AdminUI.viewforNeedBase(" ");
            List<NeedBaseTakerBL> NB = NeedBaseTakerDL.getList();
            for (int idx = 0; idx < NB.Count; idx++)
            {
                if (user.getUsername() == NB[idx].getUsername())
                {
                    AdminUI.viewNB(NB[idx]);
                }
            }
        }
        public override void option04(UserBL user)
        {
            string role = user.getRole();
            if(role == "NeedBaseTaker")
            {
                bool flag = NeedBaseTakerDL.forSchlarship(user,"00-00-0000");
                if (flag) 
                { TakerUI.printEligible("Eligible"); }
                else 
                { TakerUI.printEligible("Not Eligible"); }
            }
        }
        public override void option05(UserBL user)
        {
            string role = user.getRole();
            string date = NeedBaseTakerUI.takeInput("Date ");
            if (role == "NeedBaseTaker")
            {
                bool flag = NeedBaseTakerDL.forSchlarship(user, date);
                if (flag)
                { TakerUI.printGetScholarship("have"); }
                else
                { TakerUI.printGetScholarship("don't have"); }
            }
        }
        public override void option06(UserBL user)
        {
            List<NeedBaseTakerBL> NB = NeedBaseTakerDL.getList();
            string role = user.getRole();
            if (role == "NeedBaseTaker")
            {
                for (int idx = 0; idx < NB.Count; idx++)
                {
                    if (user.getUsername() == NB[idx].getUsername())
                    {
                        TakerUI.viewSCRecord(NB[idx].getRecord());
                    }
                }
            }
        }
        public override void option07(UserBL user)
        {
            string feedback = NeedBaseTakerUI.takeInput("FeedBack");
            bool flag = NeedBaseTakerDL.giveFeedBack(user,feedback);
            if(flag)
            {
                UserUI.done();
            }
            else
            {
                UserUI.again();
            }
        }
        public override void option08(UserBL user)
        {
            option07(user);
        }
        public override void feedBacks(UserBL user)
        {
            List<NeedBaseTakerBL> NB = NeedBaseTakerDL.getList();
            string role = user.getRole();
            if (role == "NeedBaseTaker")
            {
                for (int idx = 0; idx < NB.Count; idx++)
                {
                    if (user.getUsername() == NB[idx].getUsername())
                    {
                        string feedBack = NB[idx].getFeedbacks();
                        UserUI.viewFeedBacks(feedBack);
                        break;
                    }
                }
            }
        }
    }
}
