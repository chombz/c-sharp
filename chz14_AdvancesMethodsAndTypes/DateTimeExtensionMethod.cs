using System;

namespace chz14_AdvancesMethodsAndTypes
{
    public static class DateTimeExtensionMethod
    {
        public static string formatDate(this DateTime date)
        {
            string dateFormat = date.ToString("dd-mm-yyyy");
            return date.Year >= 2000 ? dateFormat : dateFormat.Replace("19", "");
        }
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2016, 03, 25);
            Console.WriteLine(date1.formatDate());
            DateTime date2 = new DateTime(1996, 03, 12);
            Console.WriteLine(date2.formatDate());
        }
    }
}
