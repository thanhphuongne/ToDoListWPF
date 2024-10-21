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

namespace ToDoListWPF.Views
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textFullName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtFullName.Focus();
        }
        private void txtFullName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text) && txtFullName.Text.Length > 0)
            {
                textFullName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textFullName.Visibility = Visibility.Visible;
            }
        }

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                textEmail.Visibility = Visibility.Visible;
            }
        }

        private void textPhone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPhone.Focus();
        }
        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhone.Text) && txtPhone.Text.Length > 0)
            {
                textPhone.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPhone.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void textConfirmPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtConfirmPassword.Focus();
        }
        private void txtConfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConfirmPassword.Password) && txtPassword.Password.Length > 0)
            {
                textConfirmPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textConfirmPassword.Visibility = Visibility.Visible;
            }
        }
      
        private void txtPhone_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Optionally clear the Phone Number TextBox or provide user feedback
            txtPhone.Clear();
        }


        // Sự kiện xử lý khi người dùng nhấn nút Sign Up
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Password;
            string confirmPassword = txtConfirmPassword.Password;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Add further validation and processing logic here
            MessageBox.Show("Sign up successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Sự kiện chuyển hướng đến trang Login khi người dùng nhấn vào liên kết
        private void Login_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // Điều hướng đến trang Login hoặc thực hiện hành động khác
            MessageBox.Show("Navigate to Login page.");
        }

        // Sự kiện khi nhấn vào Border để kéo cửa sổ
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {

        }
        private void cancel_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Image_Mouse(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}