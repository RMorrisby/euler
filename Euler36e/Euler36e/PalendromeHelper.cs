using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Helper class containing palendrome-related methods
/// </summary>
namespace Euler36e
{
    public class PalendromeHelper
    {

        /// <summary>
        /// Is the supplied base-10 int a palendrome?
        /// </summary>
        /// <param name="i"></param>
        /// <returns>bool</returns>
        public static bool IsBase10Palendrome(int i)
        {
            return IsBaseNPalendrome(i, 10);            
        }

        /// <summary>
        /// Is the supplied base-10 int a palendrome when it is converted into a base-2 int?
        /// </summary>
        /// <param name="i"></param>
        /// <returns>bool</returns>
        public static bool IsBase2Palendrome(int i)
        {
            return IsBaseNPalendrome(i, 2);
        }

        /// <summary>
        /// Is the supplied base-10 int a palendrome when it is converted into a base-N int?
        /// </summary>
        /// <param name="i">The original base-10 number</param>
        /// <param name="baseN">The base you wish the base-10 number to be converted into</param>
        /// <returns></returns>
        public static bool IsBaseNPalendrome(int i, int baseN)
        {
            // Convert to whatever base is specified, then convert to String, reverse & compare - is it a palendrome?
            String baseNString = Convert.ToString(i, baseN);
            return IsPalendrome(baseNString);
        }

        /// <summary>
        /// Is the supplied string a palendrome?
        /// </summary>
        /// <param name="s"></param>
        /// <returns>bool</returns>
        public static bool IsPalendrome(String s)
        {
            // Reverse & compare the string - is it a palendrome?
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            String reverse = new String(charArray);

            return (s == reverse);
        }
    }
}
