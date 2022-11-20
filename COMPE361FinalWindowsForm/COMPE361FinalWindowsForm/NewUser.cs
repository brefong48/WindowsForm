using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPE361FinalWindowsForm
{
    public class NewUser
    {
        private string name;
        private string emailaddress;
        private string password;
        private string verifypassword;
        private string idnumber;
        private string phonenumber;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailaddress;
            }
            set
            {
                emailaddress = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string VerifyPassword
        {
            get
            {
                return verifypassword;
            }
            set
            {
                verifypassword = value;
            }
        }
        public string IDNumber
        {
            get
            {
                return idnumber;
            }
            set
            {
                idnumber = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }
    }
}
