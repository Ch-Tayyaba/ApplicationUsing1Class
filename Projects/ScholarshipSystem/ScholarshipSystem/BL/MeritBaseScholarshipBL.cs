using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class MeritBaseScholarshipBL
    {
        private float percentage;
        private float scholarship;

        public float getPercentage()
        {
            return percentage;
        }
        public void setPercentage(float percentage)
        {
            this.percentage = percentage;
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
