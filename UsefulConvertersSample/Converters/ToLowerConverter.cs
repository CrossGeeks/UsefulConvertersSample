using System;
using Xamarin.Forms;

namespace UsefulConvertersSample.Converters
{
    public class ToLowerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var text = $"{value}";
            if (!string.IsNullOrEmpty(text))
                return text.ToLower();

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
