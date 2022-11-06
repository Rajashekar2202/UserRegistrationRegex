using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class ValidEmail
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
    }
}
