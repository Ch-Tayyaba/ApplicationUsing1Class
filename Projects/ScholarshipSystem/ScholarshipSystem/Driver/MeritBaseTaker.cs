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
    public class MeritBaseTaker : Taker
    {
        public override void add(UserBL user)
        {

            TakerBL info = Taker.takeInput();
            string degree = MeritBaseTakerUI.takeDegree();
            float totalMarks = MeritBaseTakerUI.takeTotalMarks();
            float obtMarks = MeritBaseTakerUI.takeObtMarks();
            MeritBaseTakerBL data = new MeritBaseTakerBL(info.getName(), info.getCNIC(), info.getFatherName(), info.getfee(), degree,totalMarks, obtMarks);
            bool flag = MeritBaseTakerDL.addToList(user, data);
            if (flag)
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
            AdminUI.viewforMeritBase(" ");
            List<MeritBaseTakerBL> MB = MeritBaseTakerDL.getList();
            for (int idx = 0; idx < MB.Count; idx++)
            {
                if (user.getUsername() == MB[idx].getUsername())
                {
                    AdminUI.viewMB(MB[idx]);
                }
            }
        }
        public override void option04(UserBL user)
        {
            string role = user.getRole();
            if (role == "MeritBaseTaker")
            {
                bool flag = MeritBaseTakerDL.forSchlarship(user, "00-00-0000");
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
                bool flag = MeritBaseTakerDL.forSchlarship(user, date);
                if (flag)
                { TakerUI.printGetScholarship("have"); }
                else
                { TakerUI.printGetScholarship("don't have"); }
            }
        }
        public override void option06(UserBL user)
        {
            List<MeritBaseTakerBL> MB = MeritBaseTakerDL.getList();
            string role = user.getRole();
            if (role == "MeritBaseTaker")
            {
                for (int idx = 0; idx < MB.Count; idx++)
                {
                    if (user.getUsername() == MB[idx].getUsername())
                    {
                        TakerUI.viewSCRecord(MB[idx].getRecord());
                    }
                }
            }
        }
        public override void option07(UserBL user)
        {
            string feedback = MeritBaseTakerUI.takeInput("FeedBack");
            bool flag = MeritBaseTakerDL.giveFeedBack(user, feedback);
            if (flag)
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
            List<MeritBaseTakerBL> MB = MeritBaseTakerDL.getList();
            string role = user.getRole();
            if (role == "MeritBaseTaker")
            {
                for (int idx = 0; idx < MB.Count; idx++)
                {
                    if (user.getUsername() == MB[idx].getUsername())
                    {
                        string feedBack = MB[idx].getFeedbacks();
                        UserUI.viewFeedBacks(feedBack);
                        break;
                    }
                }
            }
        }
    }
}
