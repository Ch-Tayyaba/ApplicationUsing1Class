using ScholarshipSystem.BL;
using ScholarshipSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.Driver
{
    public class Taker : User
    {
        public override int menu()
        {
            int option = TakerUI.menu();
            return option;
        }
        public static TakerBL takeInput()
        {
            string name = TakerUI.takeName();
            string CNIC = TakerUI.takeCNIC();
            string fatherName = TakerUI.takeFatherName();
            float fee = TakerUI.takeFee();
            TakerBL t = new TakerBL(name, CNIC, fatherName, fee);
            return t;

        }
        public override void add(UserBL user)
        {
            
        }
        public override void removeOrUpdate(UserBL user)
        {
        }
        public override void view(UserBL user)
        { }
        public override void option04(UserBL user)
        {
        }
        public override void option05(UserBL user)
        {
        }
        public override void option06(UserBL user)
        {
        }
        public override void option07(UserBL user)
        {
        }
        public override void option08(UserBL user)
        {
        }
        public override void feedBacks(UserBL user)
        {
        }

    }
}
