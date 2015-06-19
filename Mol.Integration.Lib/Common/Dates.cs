using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Mol.Integration.Lib.Common
{
    public static class Dates
    {
        private const int startGreg = 1900;
        private const int endGreg = 2100;
        private static string[] allFormats ={"yyyy/MM/dd","yyyy/M/d",
            "dd/MM/yyyy","d/M/yyyy",
            "dd/M/yyyy","d/MM/yyyy","yyyy-MM-dd",
            "yyyy-M-d","dd-MM-yyyy","d-M-yyyy",
            "dd-M-yyyy","d-MM-yyyy","yyyy MM dd",
            "yyyy M d","dd MM yyyy","d M yyyy",
            "dd M yyyy","d MM yyyy"};
        private static CultureInfo arCul = new CultureInfo("ar-SA");
        private static CultureInfo enCul = new CultureInfo("en-US");
        private static HijriCalendar h = new HijriCalendar();
        private static GregorianCalendar g = new GregorianCalendar(GregorianCalendarTypes.USEnglish);
        private static UmAlQuraCalendar u = new UmAlQuraCalendar();

        public static DateTime? GregToHijri(this DateTime greg, string format)
        {
            try
            {
                arCul.DateTimeFormat.Calendar = u;
                DateTime tempDate = DateTime.ParseExact(greg.ToString("dd/MM/yyyy"), allFormats,
                    enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
                if (string.IsNullOrEmpty(format))
                    return DateTime.Parse(tempDate.ToString("dd/MM/yyyy", arCul.DateTimeFormat));
                return DateTime.Parse(tempDate.ToString(format, arCul.DateTimeFormat));
            }
            catch (Exception ex)
            {
                //LoggingUtilities.LoggingHelper.Warn("GregToHijri :" + greg.ToString() + "\n" + ex.Message);
                return null;
            }
        }


        public static string GregToHijri(this DateTime greg)
        {
            try
            {
                arCul.DateTimeFormat.Calendar = u;
                DateTime tempDate = DateTime.ParseExact(greg.ToString("dd/MM/yyyy"), allFormats,
                    enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);

                return tempDate.ToString("dd/MM/yyyy", arCul.DateTimeFormat);
            }
            catch (Exception ex)
            {
                //LoggingUtilities.LoggingHelper.Warn("GregToHijri :" + greg.ToString() + "\n" + ex.Message);
                return null;
            }
        }



        /// <summary>
        /// Converts the greg to hijri in YYYYMMdd format.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public static int ConvertGregToHijri(DateTime gregDate)
        {
            System.Globalization.UmAlQuraCalendar calendar = new System.Globalization.UmAlQuraCalendar();
            string year = calendar.GetYear(gregDate).ToString();
            string month = calendar.GetMonth(gregDate).ToString();
            if (month.Length < 2)
                month = "0" + month;
            string day = calendar.GetDayOfMonth(gregDate).ToString();
            if (day.Length < 2)
                day = "0" + day;
            return int.Parse(year + month + day);
        }

        public static int GetHijriYear(DateTime dateTime)
        {
            System.Globalization.UmAlQuraCalendar calendar = new System.Globalization.UmAlQuraCalendar();
            return calendar.GetYear(dateTime);
        }


        public static DateTime? HijriToGreg(this string hijri)
        {
            return HijriToGreg(hijri, "-");

        }

        public static DateTime? HijriToGreg(this string hijri, string seprator)
        {
            if (hijri.Length <= 0)
            {
                //LoggingUtilities.LoggingHelper.Warn("HijriToGreg :Date String is Empty");
                return null;
            }
            try
            {
                DateTime tempDate;
                arCul.DateTimeFormat.Calendar = u;

                if (DateTime.TryParseExact(hijri, allFormats, arCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces, out tempDate))
                {
                    return tempDate;
                }
                else
                {
                    arCul.DateTimeFormat.Calendar = h;
                    if (DateTime.TryParseExact(hijri, allFormats, arCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces, out tempDate))
                        return tempDate;
                    else
                    {

                        string years = string.Empty;
                        string months = string.Empty;
                        arCul.DateTimeFormat.Calendar = u;
                        if (!string.IsNullOrEmpty(seprator) && hijri.Length > 8)
                        {
                            string[] date = hijri.Split(new string[] { seprator }, StringSplitOptions.RemoveEmptyEntries);
                            months = date[1];
                            years = date[0];
                        }
                        else if (string.IsNullOrEmpty(seprator) && hijri.Length == 8)
                        {
                            months = hijri.Substring(4, 2);
                            years = hijri.Substring(0, 4);
                        }
                        if (!string.IsNullOrEmpty(months) || !string.IsNullOrEmpty(years))
                        {
                            string hijriMove = string.Format("{0}-{1}-{2}", 1, int.Parse(months) + 1, years);
                            if (DateTime.TryParseExact(hijriMove, allFormats, arCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces, out tempDate))
                            {
                                return tempDate;
                            }
                        }
                        return null;
                    }
                }

            }
            catch (Exception ex)
            {
                //LoggingUtilities.LoggingHelper.Warn("HijriToGreg :" + hijri.ToString() + "\n" + ex.Message);
                return null;
            }
        }

        #region [ Extension Methods ]

        /// <summary>
        /// Gets the UmAlQura Year.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>UmAlQura Year</returns>
        public static int GetUmAlQuraYear(this DateTime source)
        {
            System.Globalization.UmAlQuraCalendar calendar = new System.Globalization.UmAlQuraCalendar();
            return calendar.GetYear(source);
        }

        /// <summary>
        /// Converts the Gregorian date to UmAlQura date as int.
        /// </summary>
        /// <param name="gregDate">The Gregorian date.</param>
        /// <returns>UmAlQura date as int</returns>
        public static int ConvertGregToUmAlQura(this DateTime gregDate)
        {
            System.Globalization.UmAlQuraCalendar calendar = new System.Globalization.UmAlQuraCalendar();
            string year = calendar.GetYear(gregDate).ToString();
            string month = calendar.GetMonth(gregDate).ToString();
            if (month.Length < 2)
                month = "0" + month;
            string day = calendar.GetDayOfMonth(gregDate).ToString();
            if (day.Length < 2)
                day = "0" + day;
            return int.Parse(year + month + day);
        }

        /// <summary>
        /// Converts the UmAlQura date to Gregorian date.
        /// </summary>
        /// <param name="umAlQuraDate">The UmAlQura date.</param>
        /// <returns>Gregorian date</returns>
        public static DateTime ConvertUmAlQuraToGreg(this string umAlQuraDate)
        {
            System.Globalization.UmAlQuraCalendar calendar = new System.Globalization.UmAlQuraCalendar();
            return calendar.ToDateTime(int.Parse(umAlQuraDate.Substring(0, 4)), int.Parse(umAlQuraDate.Substring(4, 2)), int.Parse(umAlQuraDate.Substring(6, 2)), 0, 0, 0, 0);
        }
        #endregion
    }
}
