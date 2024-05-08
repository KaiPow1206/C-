using static System.DateTime;
using static System.Console;


namespace SimpleUtilityClass
{
    static class TimeUtilClass
    {
        public static void PrintTime() => WriteLine(Now.ToShortTimeString());
        public static void PrintDate() => WriteLine(Today.ToLongDateString());
    }
}