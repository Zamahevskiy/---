﻿using System;
using System.Data;
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

namespace КАЛЬКУЛЯТОР
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement ZaPasana in BigBoss.Children)
            {
                if(ZaPasana is Button)
                {
                    ((Button)ZaPasana).Click += Button_Click;
                }
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = ((Button)e.OriginalSource).Content.ToString();
            if (str == "C")
                u.Clear();
            else if (str == "=")
            {
                string value = new DataTable().Compute(u.Text, null).ToString();
                u.Text = value;
            }
            else
            u.Text += str;
        }
    }
}
