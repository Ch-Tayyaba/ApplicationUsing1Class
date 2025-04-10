using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class NeedBaseScholarshipBL
    {
        private float income;
        private float scholarship;

        public float getIncome()
        {
            return income;
        }
        public void setIncome(float income)
        {
            this.income = income;
        }
        public float getScholarship()
        {
            return scholarship;
        }
        public void setScholarship(float scholarship)
        {
            this.scholarship = scholarship;
        }
    }
}
