// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Text.RegularExpressions;

namespace TDDKata
{
    internal class StringCalc
    {
        private const string DECLARE_CUSTOM_SEPARATOR_PATTERN = "(?<=//).+(?=\\n)";
        private string SEPARATOR1 = ",";
        private string SEPARATOR2 = "\n";
        private const int ERROR = -1;
        private const int EMPTY = 0;

        internal int Sum(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                return EMPTY;
            }

            var result = EMPTY;

            var separators = GetSeparators(v);

            foreach (var item in GetString(v).Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                if (!int.TryParse(item.Trim(), out var number) || number < 0)
                {
                    return ERROR;
                }

                if (number > 1000)
                    continue;

                result += number;
            }

            return result;
        }

        private string GetString(string input)
        {
            return Regex.Replace(input, @"//.+\n", string.Empty);
        }

        private string[] GetSeparators(string input)
        {
            var match = Regex.Match(input, DECLARE_CUSTOM_SEPARATOR_PATTERN);
            if (match.Success)
            {
                return new[] { match.Value };
            }

            return new[] { SEPARATOR1, SEPARATOR2 };
        }
    }
}