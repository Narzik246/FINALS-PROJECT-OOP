﻿using System;
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
    /// Interaction logic for YesNo.xaml
    /// </summary>
    public partial class YesNo : Window
    {
        public YesNo()
        {
            InitializeComponent();
        }

        private void Yes(object sender, RoutedEventArgs e)
        {
            Choices c = new Choices();
            c.Show();
            this.Close();
        }

        private void No(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
