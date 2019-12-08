using System;
using System.Globalization;
using Xamarin.Forms;

namespace UsefulConvertersSample.Converters
{
    public class DoubleToRoundedValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val && val >= 1)
            {
                return decimal.Round((decimal)val, 2, MidpointRounding.AwayFromZero);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val && val > 0)
            {
                return decimal.Round((decimal)val, 2, MidpointRounding.AwayFromZero);
            }
            return value;
        }
    }
}