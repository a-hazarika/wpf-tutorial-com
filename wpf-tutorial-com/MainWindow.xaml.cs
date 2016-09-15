using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_tutorial_com
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_eventHandler_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Double Click Position : " + e.GetPosition(this).ToString(), "Unecessary Title");
        }

        private void button_Exception_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            
            try
            {
                s.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro tratado: " + ex.StackTrace, "Erro !", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            s.Trim();
        }

        private void button_ShowSplitterScreen_Click(object sender, RoutedEventArgs e)
        {
            SplitterScreen sps = new SplitterScreen();
            sps.Show();
        }

        private void button_ShowContactInfoScreen_Click(object sender, RoutedEventArgs e)
        {
            ContactInfo cis = new ContactInfo();
            cis.Show();
        }

        private void button_HelloDataBinding_Click(object sender, RoutedEventArgs e)
        {
            HelloDataBinding hdb = new HelloDataBinding();
            hdb.Show();
        }

        private void button_ObjectControlBindingSample_Click(object sender, RoutedEventArgs e)
        {
            ObjectControlBindingSample ocbs = new ObjectControlBindingSample();
            ocbs.Show();
        }

        private void button_BindingWithConversion_Click(object sender, RoutedEventArgs e)
        {
            BindWithConversion bwc = new BindWithConversion();
            bwc.Show();
        }

        private void button_CommandSample_Click(object sender, RoutedEventArgs e)
        {
            CommandSample cs = new CommandSample();
            cs.Show();
        }
    }
}
