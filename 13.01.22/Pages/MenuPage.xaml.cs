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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _13._01._22.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        Windows.AuthWindow AW;
        MainWindow MW;
        public MenuPage(Windows.AuthWindow auth, MainWindow win)
        {
            InitializeComponent();
            AW = auth;
            MW = win;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.AW.Show();
            this.AW.ResetMainWindow();
            this.MW.Close();
        }

        private void btnBookList_Click(object sender, RoutedEventArgs e)
        {
            Page P = new Pages.BookListPage();
            this.MW.SetPage(P);
        }

        private void btnLendBook_Click(object sender, RoutedEventArgs e)
        {
            Page P = new Pages.GiveRecieveBookPage();
            this.MW.SetPage(P);
        }

        private void btnUserList_Click(object sender, RoutedEventArgs e)
        {
            Page P = new Pages.UserListPage();
            this.MW.SetPage(P);
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            Page P = new Pages.AddBookPage();
            this.MW.SetPage(P);
        }
    }
}
