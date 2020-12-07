// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace TDDKata
{
    internal class StringCalc
    {
        private const char SEPARATOR1 = ',';
        private const char SEPARATOR2 = '\n';
        private const int ERROR = -1;
        private const int EMPTY = 0;

        internal int Sum(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                return EMPTY;
            }

            var result = EMPTY;

            foreach(var item in v.Split(SEPARATOR1, SEPARATOR2))
            {
                if (!int.TryParse(item.Trim(), out var number) || number < 0)
                {
                    return ERROR;
                }

                result += number;
            }

            return result;
        }
    }
}