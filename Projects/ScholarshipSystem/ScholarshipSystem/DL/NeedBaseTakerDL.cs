using ScholarshipSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.DL
{
    public class NeedBaseTakerDL
    {
        private static List<NeedBaseTakerBL> NeedBaseTakers = new List<NeedBaseTakerBL>();
        public static bool addToList(NeedBaseTakerBL Taker)
        {
            NeedBaseTakers.Add(Taker);
            return true;
        }
        public static List<NeedBaseTakerBL> getList()
        {
            return NeedBaseTakers;
        }
        public static bool addToList(UserBL user, NeedBaseTakerBL info)
        {
            for (int idx = 0; idx < NeedBaseTakers.Count; idx++)
            {
                if (user.getUsername() == NeedBaseTakers[idx].getUsername())
                {
                    NeedBaseTakers[idx] = info;
                    return true;
                }
            }
            return false;
        }
        public static bool removeTaker(UserBL user)
        {
            for (int idx = 0; idx < NeedBaseTakers.Count; idx++)
            {
                if (user.getUsername() == NeedBaseTakers[idx].getUsername())
                {
                    NeedBaseTakers.RemoveAt(idx);
                    return true;
                }
            }
            return false;
        }
        public static bool forSchlarship(UserBL user,string date)
        {
            bool flag = false;
            for (int idx = 0; idx < NeedBaseTakers.Count; idx++)
            {
                if (user.getUsername() == NeedBaseTakers[idx].getUsername())
                {
                    flag = NeedBaseTakers[idx].getScholarship(date);
                    return flag;
                }
            }
            return flag;
        }
        public static bool giveFeedBack(UserBL user,string feedBack)
        {
            for (int idx = 0; idx < NeedBaseTakers.Count; idx++)
            {
                if (user.getUsername() == NeedBaseTakers[idx].getUsername())
                {
                    NeedBaseTakers[idx].setFeedbacks(feedBack);
                    return true;
                }
            }
            return false;
        }
    }
}
