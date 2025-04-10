using ScholarshipSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.DL
{
    public class MeritBaseTakerDL
    {
        private static List<MeritBaseTakerBL> MeritBaseTakers = new List<MeritBaseTakerBL>();
        public static bool addToList(MeritBaseTakerBL Taker)
        {
            MeritBaseTakers.Add(Taker);
            return true;
        }
        public static List<MeritBaseTakerBL> getList()
        {
            return MeritBaseTakers;
        }
        public static bool addToList(UserBL user, MeritBaseTakerBL info)
        {
            for (int idx = 0; idx < MeritBaseTakers.Count; idx++)
            {
                if (user.getUsername() == MeritBaseTakers[idx].getUsername())
                {
                    MeritBaseTakers[idx] = info;
                    return true;
                }
            }
            return false;
        }
        public static bool removeTaker(UserBL user)
        {
            for(int idx = 0; idx < MeritBaseTakers.Count; idx++)
            {
                if (user.getUsername() == MeritBaseTakers[idx].getUsername())
                {
                    MeritBaseTakers.RemoveAt(idx);
                    return true;
                }
            }
            return false;
        }
        public static bool forSchlarship(UserBL user, string date)
        {
            bool flag = false;
            for (int idx = 0; idx < MeritBaseTakers.Count; idx++)
            {
                if (user.getUsername() == MeritBaseTakers[idx].getUsername())
                {
                    flag = MeritBaseTakers[idx].getScholarship(date);
                    return flag;
                }
            }
            return flag;
        }
        public static bool giveFeedBack(UserBL user, string feedBack)
        {
            for (int idx = 0; idx < MeritBaseTakers.Count; idx++)
            {
                if (user.getUsername() == MeritBaseTakers[idx].getUsername())
                {
                    MeritBaseTakers[idx].setFeedbacks(feedBack);
                    return true;
                }
            }
            return false;
        }
    }
}
