using System;
using System.Windows;

namespace MouldCalculator.Helper
{
    public class StringHelper
    {
        public static string GetFromResource(string resourceName)
        {
            try
            {
                return (string)Application.Current.FindResource(resourceName);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
