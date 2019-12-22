using System.Linq;
using System.Text.RegularExpressions;

namespace Crosscutting.Attributes
{
    public static class Mod11
    {
        public static bool IsValid(string pValue, int pValueValidLength, string[] pMaskChars, int[] pMultipliersForFirstDigit, int[] pMultipliersForSecondDigit)
        {
            string valueWithoutMask = GetValueWithoutMask(pValue, pMaskChars);

            bool isInvalid =
                IsInvalidLength(valueWithoutMask, pValueValidLength) ||
                IsNotNumbersOnly(valueWithoutMask) ||
                IsNotInvalidSequence(pValue) ||
                IsInvalidMod11(pMultipliersForFirstDigit, pMultipliersForSecondDigit, valueWithoutMask);

            return !isInvalid;
        }

        private static string GetValueWithoutMask(string pValue, string[] pMaskChars)
        {
            foreach (string item in pMaskChars)
            {
                pValue = pValue.Replace(item, string.Empty);
            }
            return pValue;
        }

        private static bool IsInvalidLength(string pValue, int pValueValidLength)
        {
            return pValue.Length != pValueValidLength;
        }

        private static bool IsNotNumbersOnly(string pValue)
        {
            return !Regex.IsMatch(pValue, @"\d+");
        }

        private static bool IsNotInvalidSequence(string pValue)
        {
            bool allCharsAreEqual = pValue.Distinct().Count() == 1;
            return allCharsAreEqual;
        }

        private static bool IsInvalidMod11(int[] pMultipliersForFirstDigit, int[] pMultipliersForSecondDigit, string pValue)
        {
            int firstDigit = GetFirstDigit(pMultipliersForFirstDigit, pValue);
            int secondDigit = GetSecondDigit(pMultipliersForSecondDigit, pValue, firstDigit);
            string expectedSufix = string.Concat(firstDigit, secondDigit);
            bool isInvalid = !pValue.EndsWith(expectedSufix);
            return isInvalid;
        }

        private static int GetFirstDigit(int[] pMultipliers, string pValue)
        {
            string valueToWork = pValue.Substring(0, pMultipliers.Length);
            int sum = pMultipliers
                .Select((d, i) => new
                {
                    Value = int.Parse(valueToWork[i].ToString()),
                    Multiplier = pMultipliers[i]
                }).Sum(d => d.Value * d.Multiplier);

            int rest = sum % 11;
            int firstDigit = rest < 2 ? 0 : 11 - rest;

            return firstDigit;
        }

        private static int GetSecondDigit(int[] pMultipliers, string pValue, int pFirstDigit)
        {
            string valueToWork = string.Concat(pValue.Substring(0, pMultipliers.Length - 1), pFirstDigit);
            int sum = pMultipliers
                .Select((d, i) => new
                {
                    Value = int.Parse(valueToWork[i].ToString()),
                    Multipler = d
                }).Sum(d => d.Value * d.Multipler);

            int rest = sum % 11;
            int secondDigit = rest < 2 ? 0 : 11 - rest;

            return secondDigit;
        }
    }
}
