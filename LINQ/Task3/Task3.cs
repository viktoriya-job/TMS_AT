using LINQ.Helper;

namespace LINQ
{
    internal class Task3
    {
        public static void Run()
        {
            List<string> _stringList = new List<string>()
            {
                "VKWHGK",
                "SA",
                "SCHA",
                "HT",
                "ADVL",
                "SDFVGKJLVK",
                "DFVN",
                "SW"
            };

            var result = _stringList.OrderBy(item => item.Length).ThenByDescending(item => item);

            PrintHelper.PrintCollection(result);
        }
    }
}