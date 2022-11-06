using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class ValidPassword
    {
        public static string User_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public bool FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, User_FirstName);
        }

        public static string User_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public bool LastName(string lastName)
        {
            return Regex.IsMatch(lastName, User_LastName);
        }

        public static string User_EmailId = "^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}([.][A-Za-z]{2})?$";
        public bool EmailId(string emailId)
        {
            return Regex.IsMatch(emailId, User_EmailId);
        }

        public static string User_MobileNumber = "^[0-9]{2}[0-9]{10}";
        public bool MobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, User_MobileNumber);
        }

        public static string User_PasswordRule1 = "^[a-zA-z0-9]{8,16}$";
        public bool Password(string password)
        {
            return Regex.IsMatch(password, User_PasswordRule1);
        }
    }
}
