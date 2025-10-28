using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLibrary
{
    public static class DateConstants
    {
        public const string DateSeparator = "/";
        public const int ExpectedDatePartsCount = 3;
        public const int FormatDDMMYYYY = 1;
        public const int FormatMMDDYYYY = 2;
        public const int MinYear = 1;
        public const int MaxYear = 9999;
        public const int MinMonth = 1;
        public const int MaxMonth = 12;
        public const int MinDay = 1;
    }
}
