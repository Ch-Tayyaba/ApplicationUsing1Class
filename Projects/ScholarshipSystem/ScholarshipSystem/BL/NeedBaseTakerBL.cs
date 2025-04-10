using ScholarshipSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class NeedBaseTakerBL : TakerBL
    {
        private string designation;
        private float income;
            
        public NeedBaseTakerBL()
        { }
        public NeedBaseTakerBL(string name, string password) : base(name, password)
        { }
        public NeedBaseTakerBL(string designation, float income)
        {
            this.designation = designation; 
            this.income = income;
        }
        public NeedBaseTakerBL(string name, string CNIC, string fatherName, float fee, string designation, float income) : base(name, CNIC, fatherName,fee)
        {
            this.designation = designation;
            this.income = income;
        }
        public string getDesignation()
        {
            return designation;
        }
        public void setDesignation(string designation)
        {
            this.designation = designation;
        }
        public float getIncome()
        {
            return income;
        }
        public void setIncome(float income)
        {
            this.income = income;
        }
        public bool getScholarship(string date)
        {
            List <NeedBaseScholarshipBL> lst = AdminDL.getNBList();
            for(int idx = 0; idx < lst.Count; idx++)
            {
                if(lst[idx].getIncome() <= income)
                {
                    double scholarship = lst[idx].getScholarship();
                    double amount = AdminDL.getDonationAmount();
                    AdminDL.setDonationAmount(amount - lst[idx].getIncome());
                    double amount02 = AdminDL.getDonatedAmount();
                    AdminDL.setDonatedAmount(amount02 + lst[idx].getIncome());
                    record.setScholarship(scholarship);
                    record.setDate(date);
                    return true;
                }
            }
            return false;
        }
    
    }
}
