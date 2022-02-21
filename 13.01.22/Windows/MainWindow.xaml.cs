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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _13._01._22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int id;
        public MainWindow(Windows.AuthWindow auth, int ID)
        {
            InitializeComponent();
            MainFrame.Content = new Pages.MenuPage(auth, this);
            this.id = ID;
        }

        public void SetPage(Page P)
        {
            MainFrame.Content = P;
        }
    }
}
