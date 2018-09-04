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
using System.Windows.Shapes;

namespace Passwords
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void EmailField_Initialized(object sender, EventArgs e)
        {
            //No longer needed, moved to EmailRectangle to fix error
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.EmailAdress = EmailField.Text;
            Properties.Settings.Default.Save();
            if (EmailField.Text == "")
            {
                EmailStoredRectangle.Fill = new SolidColorBrush(Colors.Red);
            }
            else
            {
                EmailStoredRectangle.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void EmailStoredRectangle_Initialized(object sender, EventArgs e)
        {
            EmailField.Text = Properties.Settings.Default.EmailAdress;
            if (EmailField.Text == "")
            {
                EmailStoredRectangle.Fill = new SolidColorBrush(Colors.Red);
            }
            else
            {
                EmailStoredRectangle.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void SaveButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.EmailAdress2 = EmailField_Copy.Text;
            Properties.Settings.Default.Save();
            if (EmailField.Text == "")
            {
                EmailStoredRectangle_Copy.Fill = new SolidColorBrush(Colors.Red);
            }
            else
            {
                EmailStoredRectangle_Copy.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void EmailStoredRectangle_Copy_Initialized(object sender, EventArgs e)
        {
            EmailField_Copy.Text = Properties.Settings.Default.EmailAdress2;
            if (EmailField_Copy.Text == "")
            {
                EmailStoredRectangle_Copy.Fill = new SolidColorBrush(Colors.Red);
            }
            else
            {
                EmailStoredRectangle_Copy.Fill = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
