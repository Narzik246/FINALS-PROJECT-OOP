using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Choices.xaml
    /// </summary>
    public partial class Choices : Window
    {
        Methods m = new Methods();
        public Choices()
        {
            InitializeComponent();
        }
        private void Check(object sender, RoutedEventArgs e)
        {
            Check check = new Check();
            check.Show();
            this.Close();
        }

        private void Withdraw(object sender, RoutedEventArgs e)
        {
            Withdraw w = new Withdraw();
                w.Show();
            this.Close();
        }

        private void Deposit(object sender, RoutedEventArgs e)
        {
            Deposit d = new Deposit();
                d.Show();
            this.Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
