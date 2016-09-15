using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpf_tutorial_com
{
    /// <summary>
    /// Interaction logic for BindWithConversion.xaml
    /// </summary>
    public partial class BindWithConversion : Window
    {
        public BindWithConversion()
        {
            InitializeComponent();
        }
    }

    public class TextToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value as string).ToLower().Equals("yes")) return true;
            else if((value as string).ToLower().Equals("no")) return false;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if ((bool)value) return "Yes";
            }
            return "No";
        }
    }
}
