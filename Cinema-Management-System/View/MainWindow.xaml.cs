﻿using Cinema_Management_System.View;
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

namespace Cinema_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count;
        public RegisterControl registerControl = new RegisterControl();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            //UserWindow userWindow = new UserWindow();
            //userWindow.ShowDialog();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ++count;
            
           
            MainGrid.Children.Add(registerControl);
           
           
        }
    }
}
