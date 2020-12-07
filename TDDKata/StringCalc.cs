// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;

namespace TDDKata
{
    internal class StringCalc
    {
        private const char separatov = ',';

        internal int Sum(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                return 0;
            }

            var result = 0;

            foreach(var item in v.Split(separatov))
            {
                if (!int.TryParse(item.Trim(), out var number) || number < 0)
                {
                    return -1;
                }

                result += number;
            }

            return result;
        }
    }
}