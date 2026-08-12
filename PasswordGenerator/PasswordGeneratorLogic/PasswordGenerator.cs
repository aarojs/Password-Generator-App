using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public static class PasswordGenerator
    {
        public static string Generate(int length, bool upper, bool lower, bool numbers, bool symbols)
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string numberChars = "0123456789";
            const string symbolsChars = "!@#$%^&*()-_=+";

            string pool = "";
            if (upper) pool += upperChars;
            if (lower) pool += lowerChars;
            if (numbers) pool += numberChars;
            if (symbols) pool += symbolsChars;

            if (pool.Length == 0)
                throw new ArgumentException("Select at least one character type.");

            var random = new Random();
            var result = new char[length];
            for ( int i = 0; i < length; i++) 
                result[i] = pool[random.Next(pool.Length)];

            return new string(result);

        }
    }
}
