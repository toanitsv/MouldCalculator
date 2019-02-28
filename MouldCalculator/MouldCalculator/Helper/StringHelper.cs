using System.Windows;

namespace MouldCalculator.Helper
{
    public class StringHelper
    {
        public static string GetFromResource(string resourceName)
        {
            return (string)Application.Current.FindResource(resourceName);
        }
    }
}
