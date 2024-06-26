using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FINALS_PROJECT_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Methods m = new Methods();
        Button b = new Button();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Numpad1(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            Bar.Text += b.Content;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            Bar.Text = "";
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < m.Accs.Count; i++)
            {
                if (m.Accs[i][0] == Bar.Text)
                {
                    using (StreamWriter sw = new StreamWriter("C:\\Users\\Krizan246\\Downloads\\Index.txt"))
                    {
                        sw.Write(i);
                    }
                    Choices c = new Choices();
                    c.Show();
                    this.Close();
                    break;
                }
            }
        }
    }
}