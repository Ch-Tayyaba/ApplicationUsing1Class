using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipSystem.BL
{
    public class UserBL
    {
        protected string username;
        protected string password;
        protected string role;
        public static char[,] frame;

        public UserBL()
        {
        }
        public UserBL(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public UserBL(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public string getUsername()
        {
            return username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return password;

        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getRole()
        {
            return role;
        }
        public void setRole(string role)
        {
            this.role = role;
        }

        
    }
}
