using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for ObjectControlBindingSample.xaml
    /// </summary>
    public partial class ObjectControlBindingSample : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public ObjectControlBindingSample()
        {
            InitializeComponent();

            this.users.Add(new User() { Name = "Teresa" });
            this.users.Add(new User() { Name = "Philip" });
            this.users.Add(new User() { Name = "Joe" });

            listBox_Names.ItemsSource = this.users;
        }

        private void button_addUser_Click(object sender, RoutedEventArgs e)
        {
            this.users.Add(new User() { Name = "New User"});
        }

        private void button_editUser_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_Names.SelectedItem != null)
                (listBox_Names.SelectedItem as User).Name = "Changed Wilson";
        }

        private void button_deleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (listBox_Names.SelectedItem != null)
                users.Remove(listBox_Names.SelectedItem as User);
        }

        public class User : INotifyPropertyChanged
        {
            public string name; 
            public string Name {
                get { return this.name; }
                set
                {
                    if(this.name != value)
                    {
                        this.name = value;
                        this.NotifyPropertyChanged("Name");
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public void NotifyPropertyChanged(string propName)
            {
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

        }
    }
}
