using System.Linq;
using System.Text.RegularExpressions;

namespace BackendChallenge.API.Services
{
    public class PasswordService : IPasswordService
    {
        public bool IsValidPassword(string password)
        {
            return
                HasMinLength(password)
                && !HasWhiteSpace(password)
                && !HasDuplicatedChar(password)
                && HasUpperCase(password)
                && HasLowerCase(password)
                && HasNumber(password)
                && HasSpecialChar(password);
        }

        public bool HasMinLength(string password)
        {
            bool result = password.Length >= 9;
            return result;
        }

        public bool HasWhiteSpace(string password)
        {
            bool result = password.Any(p => char.IsWhiteSpace(p));
            return result;
        }

        public bool HasUpperCase(string password)
        {
            Regex upperChar = new Regex(@"[A-Z]+");
            return upperChar.IsMatch(password);
        }

        public bool HasLowerCase(string password)
        {
            Regex lowerChar = new Regex(@"[a-z]+");
            return lowerChar.IsMatch(password);
        }

        public bool HasNumber(string password)
        {
            Regex hasNumber = new Regex(@"[0-9]+");
            return hasNumber.IsMatch(password);
        }

        public bool HasSpecialChar(string password)
        {
            string specialChar = @"!@#$%^&*()-+";
            foreach (var item in specialChar)
            {
                if (password.Contains(item)) return true; 
            }

            return false;
        }

        public bool HasDuplicatedChar(string password)
        {
            bool result = password.GroupBy(x => x).Any(g => g.Count() > 1);
            return result;
        }
    }
}
