using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class AdminBL : UserBL
    {
        private double  donationAmount;
        private double donatedAmount;
        private List<MeritBaseScholarshipBL> MBScholarship;
        private List<NeedBaseScholarshipBL> NBScholarship;

        public AdminBL()
        { }
        public AdminBL(string username, string password, string role) : base(username, password, role)
        {

        }
        public double getDonationAmount()
        {
            return donationAmount;
        }
        public void setDonationAmount(double donationAmount)
        {
            this.donationAmount = donationAmount;
        }
        public double getDonatedAmount()
        {
            return donatedAmount;
        }
        public void setDonatedAmount(double donatedAmount)
        {
            this.donatedAmount = donatedAmount;
        }
        public void setNBscholarship(List<NeedBaseScholarshipBL> u)
        {
            NBScholarship = u;
        }
        public void setMBscholarship(List<MeritBaseScholarshipBL> u)
        {
            MBScholarship = u;
        }
    }
}
