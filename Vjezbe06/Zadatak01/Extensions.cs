namespace Zadatak01
{
    public static class Extensions
    {
        public static string Format(this int value, string unit) => $"{value}{unit}";
        public static string Format(this double value, string unit) => $"{value}{unit}";
    }
}