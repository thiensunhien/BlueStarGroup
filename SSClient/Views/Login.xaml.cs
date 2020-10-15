using SSCommon.Models;
using SSServer.Controllers;
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

namespace SSClient.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserId_TextBox.Text) || string.IsNullOrWhiteSpace(Pass_PasswordBox.Password))
            {
                MessageBox.Show("User or Pass is not empty!");
                return;
            }

            LoginController login = new LoginController();
            Users user = login.GetUserInfo(UserId_TextBox.Text);

            if (user.Password == Pass_PasswordBox.Password)
            {
                Window window = new Main();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User or Pass is invalid!");
            }
        }
    }
}
