using System;
using System.Collections.Generic;
using System.Text;

namespace Euler36e
{
    /// <summary>
    /// Class representing a number as used for Euler probelm 36
    /// Contains an int, and whether it is a base-10 and/or base-2 palendrome
    /// </summary>
    class Euler36Number
    {
        public int Number { get; }
        public bool IsBase2Palendrome { get; }
        public bool IsBase10Palendrome { get; }

        public Euler36Number(int number)
        {
            Number = number;
            IsBase2Palendrome = PalendromeHelper.IsBase2Palendrome(number);
            IsBase10Palendrome = PalendromeHelper.IsBase10Palendrome(number);
        }

    }
}
