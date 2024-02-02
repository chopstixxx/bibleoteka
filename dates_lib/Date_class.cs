namespace dates_lib
{
    public class Date_class
    {
        public TimeSpan Get_date_diff(DateTime dt1, DateTime dt2)
        {
            return dt2 - dt1;

        }
        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);

        }
        public string get_time(DateTime dt)
        {
            if (dt.Hour >= 4 && dt.Hour <= 11)
            {
                return "Утро";
            }
            else if (dt.Hour >= 12 && dt.Hour <= 17)
            {
                return "День";
            }
            else if (dt.Hour >= 18 && dt.Hour <= 23)
            {
                return "Вечер";
            }
            else
            {
                return "Ночь";
            }
        }

        public string date_format(DateTime dt, string format)
        {
            return dt.ToString(format);
        }
    }
}