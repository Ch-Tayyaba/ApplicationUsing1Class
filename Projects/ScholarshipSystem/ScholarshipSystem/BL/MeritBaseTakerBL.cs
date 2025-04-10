using ScholarshipSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class MeritBaseTakerBL : TakerBL
    {
        private string degreeName;
        private float totalMarks;
        private float obtMarks;
        private float percentage;

        public MeritBaseTakerBL()
        { }
        public MeritBaseTakerBL(string degreeName, float totalMarks, float obtMarks)
        {
            this.degreeName = degreeName;
            this.totalMarks = totalMarks;
            this.obtMarks = obtMarks;
        }
        public MeritBaseTakerBL(string name, string password) : base(name, password)
        { }
        public MeritBaseTakerBL(string name,string CNIC, string fatherName, float fee, string degreeName, float totalMarks, float obtMarks): base(name,CNIC,fatherName,fee)
        {
            this.degreeName = degreeName;
            this.totalMarks = totalMarks;
            this.obtMarks = obtMarks;
        }

        public string getdegree()
        {
            return degreeName;
        }
        public void setDegree(string degree)
        {
            this.degreeName = degree;
        }
        public float getTotalMarks()
        {
            return totalMarks;
        }
        public void setTotalMarks(float totalMarks)
        {
            this.totalMarks = totalMarks;
        }
        public float getObtMarks()
        {
            return obtMarks;
        }
        public void setObtMarks(float obtMarks)
        {
            this.obtMarks = obtMarks;
        }
        public bool getScholarship(string date)
        {
            List<MeritBaseScholarshipBL> lst = AdminDL.getMBList();
            for (int idx = 0; idx < lst.Count; idx++)
            {
                if (lst[idx].getPercentage() <= percentage)
                {
                    float percentage = lst[idx].getScholarship();
                    double scholarship = getPercentageOfFee(percentage, fee);
                    double amount = AdminDL.getDonationAmount();
                    AdminDL.setDonationAmount(amount - scholarship);
                    double amount02 = AdminDL.getDonatedAmount();
                    AdminDL.setDonatedAmount(amount02 + scholarship);
                    record.setScholarship(scholarship);
                    record.setDate(date);
                    return true;
                }
            }
            return false;
        }
        public static double getPercentageOfFee(float percentage, float fee)
        {
            double finalFee = (percentage/100.0) * fee;
            return finalFee;
        }
    }
}
