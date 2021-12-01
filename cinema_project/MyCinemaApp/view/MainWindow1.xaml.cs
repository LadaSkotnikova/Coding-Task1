using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using cinema_project.Model;
using cinema_project.view_model;
using MyCinemaApp.view;

namespace MyCinemaApp.view
{
    /// <summary>
    /// Логика взаимодействия для MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Cafeview myCafeview = new Cafeview();
            myCafeview.Show();
            myCafeview.Owner = this;
            this.Hide();
        }
    }
  
}
