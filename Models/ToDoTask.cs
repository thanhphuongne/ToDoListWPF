using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListWPF.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }          // Mã định danh duy nhất cho mỗi Task
        public string Name { get; set; }     // Tên công việc
        public string Description { get; set; }  // Mô tả công việc
        public DateTime DueDate { get; set; }    // Ngày đến hạn
        public bool IsCompleted { get; set; }    // Trạng thái hoàn thành
        public int Priority { get; set; }        // Mức độ ưu tiên

        // Constructor mặc định
        public ToDoTask()
        {
            Name = "Default Name"; // Giá trị mặc định
            Description = "Default Description"; // Giá trị mặc định
        }

        // Constructor có tham số (tuỳ chọn nếu cần)
        public ToDoTask(int id, string name, string description, DateTime dueDate, bool isCompleted, int priority)
        {
            Id = id;
            Name = name;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
            Priority = priority;
        }
    }
}
