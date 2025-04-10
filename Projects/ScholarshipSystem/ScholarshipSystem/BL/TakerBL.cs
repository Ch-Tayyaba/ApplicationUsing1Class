using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class TakerBL : UserBL
    {
        protected string name;
        protected string CNIC;
        protected string fatherName;
        protected float fee;
        protected ScholarshipBL record;
        protected string feedBacks;

        public TakerBL()
        { }
        public TakerBL(string name, string CNIC, string fatherName, float fee)
        {
            this.name = name;
            this.CNIC = CNIC;
            this.fatherName = fatherName;
            this.fee = fee;
        }
        public TakerBL(string name, string password) : base(name, password)
        { }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getCNIC()
        {
            return CNIC;
        }
        public void setCNIC(string CNIC)
        {
            this.CNIC = CNIC;
        }
        public string getFatherName()
        {
            return fatherName;
        }
        public void setFatherName(string fatherName)
        {
            this.fatherName = fatherName;
        }
        public float getfee()
        {
            return fee;
        }
        public void setfee(float fee)
        {
            this.fee = fee;
        }
        public string getFeedbacks()
        {
            return feedBacks;
        }
        public void setFeedbacks(string feedbacks)
        {
            this.feedBacks = feedbacks;
        }
        public void setRecord(ScholarshipBL record)
        {
            this.record = record;
        }
        public ScholarshipBL getRecord()
        {
            return record;

        }
       
    }
}
