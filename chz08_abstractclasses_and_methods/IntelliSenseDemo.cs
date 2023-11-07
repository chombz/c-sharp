using System;
using System.Globalization;

namespace chz08_abstractclasses_and_methods
{
    /// <summary>
    /// C# program that checks timezones
    /// </summary>
    [Obsolete]
    public class IntelliSenseDemo : TimeZone
    {
        public override string DaylightName
        {
            get
            {
                return TimeZoneInfo.Local.IsDaylightSavingTime(DateTime.Now);
            }
        }

        public override string StandardName
        {
            get
            {
                return TimeZoneInfo.Local.StandardName;
            }
        }

        public override DaylightTime GetDaylightChanges(int year)
        {
            return TimeZoneInfo.Local.GetAdjustmentRules()[0].DaylightTime;
        }

        public override TimeSpan GetUtcOffset(DateTime time)
        {
            return TimeZoneInfo.Local.GetUtcOffset(time);
        }
    }
}
