namespace RetailCalculator.Framework.ConsoleApp.Application
{
    public static class StringExtensions
    {
        public static string ToTaxPercentage(this float tax)
        {
            var taxPercent = tax * 100;
            return $"{taxPercent} %";
        }
    }
}
