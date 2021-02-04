using System;
using System.Globalization;
using System.Windows.Data;

namespace WPF
{
	 public class EnumMatchToBooleanConverter : IValueConverter
	 {
		  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		  {
				if (value == null || parameter == null) return false;
				
				string checkVal = value.ToString();
				string targetVal = parameter.ToString();
				
				return checkVal.Equals(targetVal, StringComparison.InvariantCultureIgnoreCase);
		  }

		  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		  {
				if (value == null || parameter == null) return false;

				bool useVal = (bool)value;
				string targetVal = parameter.ToString();

				if (useVal) return Enum.Parse(targetType, targetVal);

				return null;
		  }
	 }
}
