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
using System.Windows.Shapes;

namespace ToDoListWPF
{
    /// <summary>
    /// Interaction logic for ChangeTaskWindow.xaml
    /// </summary>
    public partial class ChangeTaskWindow : Window
    {
        public ChangeTaskWindow()
        {
            InitializeComponent();
        }
        //private void SaveTaskButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Lấy giá trị từ các trường nhập liệu
        //    string taskTitle = TaskTitleTextBox.Text;
        //    string taskDescription = TaskDescriptionTextBox.Text;
        //    DateTime? dueDate = DueDatePicker.SelectedDate;

        //    // Kiểm tra và xử lý việc lưu tác vụ (thêm mã của bạn ở đây)
        //    if (string.IsNullOrEmpty(taskTitle))
        //    {
        //        MessageBox.Show("Please enter a task title.");
        //        return;
        //    }

        //    // Thực hiện lưu tác vụ
        //    // Code để lưu tác vụ vào cơ sở dữ liệu hoặc danh sách...

        //    MessageBox.Show("Task saved successfully!");
        //    this.Close(); // Đóng cửa sổ sau khi lưu
        //}

        //private void CancelButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close(); // Đóng cửa sổ mà không lưu thay đổi
        //}

        //private void TaskTitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}

        //private void SaveTaskButton_Click_1(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
