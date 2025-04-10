using ScholarshipSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.DL
{
    public class AdminDL
    {
        private static AdminBL admin = new AdminBL("Tayyaba", "123", "Admin");
        private static List<MeritBaseScholarshipBL> MBScholarship = new List<MeritBaseScholarshipBL>();
        private static List<NeedBaseScholarshipBL> NBScholarship = new List<NeedBaseScholarshipBL>();
        public static void defineAdmin()
        {
            UserDL.addToList(admin);
        }
        public static  AdminBL getAdmin()
        {
            return admin;
        }
        public static bool setDonationAmount(double amount)
        {
            admin.setDonationAmount(amount);
            return true;
        }
        public static bool setDonatedAmount(double amount)
        {
            admin.setDonatedAmount(amount);
            return true;
        }
        public static double getDonationAmount()
        {
            return admin.getDonationAmount();
        }
        public static double getDonatedAmount()
        {
            return admin.getDonatedAmount();
        }
        public static  List<MeritBaseScholarshipBL> getMBList()
        {
            return MBScholarship;
        }
        public static List<NeedBaseScholarshipBL> getNBList()
        {
            return NBScholarship;
        }
        public static bool addToNBList(NeedBaseScholarshipBL u)
        {
            NBScholarship.Add(u);
            return true;
        }
        public static bool addToMBList(MeritBaseScholarshipBL u)
        {
            MBScholarship.Add(u);
            return true;
        }
        public static bool throwNBToAdmin()
        {
            admin.setNBscholarship(NBScholarship);
            return true;
        }
        public static bool throwMBToAdmin()
        { 
            admin.setMBscholarship(MBScholarship);
            return true;
        }
    }
 
}
