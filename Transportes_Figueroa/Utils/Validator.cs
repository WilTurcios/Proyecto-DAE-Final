using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Transportes_Figueroa.Utils
{
    internal class Validator
    {

        public static bool IsValidEmail(string email)
        {
            string patronEmail = @"^\w+([.-_+]?\w+)*@\w+([.-]?\w+)*(\.\w{2,10})+$";

            return Regex.IsMatch(email, patronEmail);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Expresión regular para el formato "+503 6789-2334", "67894576" o "5667-1233"
            string pattern = @"^(?:\+503\s?)?(?:(?:\d{4}-){1,2}\d{4}|\d{8})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static bool IsValidDUI(string dui)
        {
            // Expresión regular para el formato "10389498-4", "2837393445-5", "123456789", "123456789123"
            string pattern = @"^\d{8}-?\d{1}$|^\d{9,10}-?\d{1}$";
            return Regex.IsMatch(dui, pattern);
        }

    }
}
