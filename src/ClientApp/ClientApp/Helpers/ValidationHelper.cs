using System;
using System.Text.RegularExpressions;

namespace ClientApp.Helpers
{
    public static class ValidationHelper
    {
        private static readonly Regex phoneRegex = new Regex(@"^((8|\+7)[\-]?)?(\(?\d{3}\)?[\-]?)?[\d\-]{7,10}$");
        private static readonly Regex emailRegex = new Regex(@"^(?=.{1,64}@)[A-Za-z0-9_-]+(\.[A-Za-z0-9_-]+)*@[^-][A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*(\.[A-Za-z]{2,})$");

        public static bool ValidatePhone(string input) => 
            !string.IsNullOrEmpty(input) &&
            phoneRegex.IsMatch(input);
        public static bool ValidateEmail(string input) =>
            !string.IsNullOrEmpty(input) &&
            emailRegex.IsMatch(input);
    }
}