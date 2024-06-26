using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FINALS_PROJECT_OOP
{
    /// <summary>
    /// Interaction logic for Check.xaml
    /// </summary>
    public partial class Check : Window
    {
        Methods m = new Methods();
        MainWindow mw = new MainWindow();
        public Check()
        {
            InitializeComponent();
            Amount.Content = m.Accs[m.index][1];

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Choices c = new Choices();
            c.Show();
            this.Close();
        }

        private void LogIN(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
