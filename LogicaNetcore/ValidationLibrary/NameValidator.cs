using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationLibrary
{
    public static class NameValidator
    {
        public static bool ValidName(string name)
        {
            string pattern = @"^([A-Z][a-z]*\.?)(\s[A-Z][a-z]*\.?){1,2}$";
            if (!Regex.IsMatch(name, pattern))
            {
                return false;
            }

            string[] parts = name.Split(' ');

            if (parts[^1].EndsWith('.'))
            {
                return false;
            }

            if (parts.Length == 3)
            {
                bool firstIsInitial = parts[0].EndsWith(".");
                bool secondIsInitial = parts[1].EndsWith(".");

                if (firstIsInitial && !secondIsInitial)
                {
                    return false; 
                }
            }

            return true;
        }
    }
}
