using System;
using System.Globalization;
using Xamarin.Forms;

namespace ToDoApp.Converters
{
    public class SatusColorConverter : IValueConverter
    {
        public object Convert(object value, Type tergetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? (Color)Application.Current.Resources["CompletedColor"] : (Color)Application.Current.Resources["ActiveColor"];
        }

        public object ConvertBack(object value, Type tergetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
