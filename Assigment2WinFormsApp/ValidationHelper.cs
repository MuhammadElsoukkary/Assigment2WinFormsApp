using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Assigment2WinFormsApp
{
    internal class ValidationHelper
    {
        private static List<string> validProvinceCodes = new List<string>
{
    "NL",
    "PE",
    "NS",
    "QC",
    "ON",
    "MB",
    "SK",
    "AB",
    "BC",
    "YT",
    "NT",
    "NU",
    "nl",
    "pe",
    "ns",
    "qc",
    "on",
    "mb",
    "sk",
    "ab",
    "bc",
    "yt",
    "nt",
    "nu"
};


        private static Regex _isValidPostalCode = new Regex(@"^\d{3}[ |-]?[A-Z]{3}$", RegexOptions.IgnoreCase);
        private static Regex _isValidPhoneNumber = new Regex(@"^\d{3}-\d{3}-\d{4}$");

        public ValidationHelper()
        {
            // Ensure the province codes list contains uppercase elements for case-insensitive validation
            validProvinceCodes = validProvinceCodes.ConvertAll(code => code.ToUpper());
        }

        public static string Capitalize(string postalCode)
        {
            if (string.IsNullOrEmpty(postalCode))
            {
                return string.Empty;
            }

            string[] words = postalCode.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0 || words[i].Length > 1) // Check if it's the first word or not a 1-letter word
                {
                    words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i].ToLower());
                }
                else
                {
                    words[i] = words[i].ToLower(); // Keep 1-letter words in lowercase
                }
            }

            return string.Join(" ", words);
        }

        public static bool IsValidPostalCode(string postalCode)
        {
            if (string.IsNullOrEmpty(postalCode))
            {
                return false;
            }

            if (!_isValidPostalCode.IsMatch(postalCode))
            {
                return false;
                

            }

            return true;
            
        }

        public static bool IsValidProvinceCode(string provinceCode)
        {
            if (string.IsNullOrEmpty(provinceCode))
            {
                return false;
            }

            if (!validProvinceCodes.Contains(provinceCode))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidPhoneNumber(string cellPhone,string homePhone)
        {
            if (string.IsNullOrEmpty(cellPhone))
            {
                return false;
            }

            if (!_isValidPhoneNumber.IsMatch(cellPhone))
            {
                return false;
            }

            if (string.IsNullOrEmpty(homePhone))
            {
                return false;
            }

            if (!_isValidPhoneNumber.IsMatch(homePhone ))
            {
                return false;
            }
            return true;
        }
    }

   
}


