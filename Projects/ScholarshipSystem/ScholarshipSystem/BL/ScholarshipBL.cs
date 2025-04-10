using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class ScholarshipBL
    {
        private double scholarship;
        private string date;
        
        public void setScholarship(double scholarship)
        {
            this.scholarship = scholarship;
        }
        public double getScholarship()
        {
            return scholarship;
        }
        public void setDate(string date)
        {
            this.date = date;
        }
        public string getDate()
        {
            return date;
        }
    }
}
