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

namespace FINALS_PROJECT_OOP
{
    /// <summary>
    /// Interaction logic for Withdraw.xaml
    /// </summary>
    public partial class Withdraw : Window
    {
        Choices c = new Choices();
        Methods m = new Methods();
        Button b = new Button();
        public Withdraw()
        {
            InitializeComponent();
            Bar.Text = "0";
        }

        private void Numpad1(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            Bar.Text += b.Content;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            Bar.Text = "0";
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            YesNo yn = new YesNo();
            if ((int.Parse(Bar.Text)<= int.Parse(m.Accs[m.index][1])))
            {
                m.Accs[m.index][1] =   (int.Parse(m.Accs[m.index][1]) - int.Parse(Bar.Text)).ToString();
                m.Write();
                MessageBox.Show($"Transaction Complete: New Balance of {m.Accs[m.index][1]}");
                yn.Show();
                this.Close();
            }
            else
                MessageBox.Show("That isn't a valid input");
            
        }

        private void Return(object sender, RoutedEventArgs e)
        {
            Choices c = new Choices();
            c.Show();
            this.Close();
        }
    }
}
