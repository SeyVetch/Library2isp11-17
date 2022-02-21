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

namespace _13._01._22.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        Window MW;
        public AuthWindow()
        {
            InitializeComponent();
        }

        public void ResetMainWindow()
        {
            this.MW = null;
        }
        private void LogBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LogBox.Text;
            string password = PasBox.Text;
            int ID = ClassHelper.TestCredentials.ID(login, password);
            if (ID != -1)
            {
                this.MW = new MainWindow(this, ID);
                this.Hide();
                this.MW.Show();
            }
        }
    }
}
