using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ToDoListWPF.Models;

namespace ToDoListWPF.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ToDoTask> Tasks { get; set; } // Danh sách các công việc

        private ToDoTask? _selectedTask;
        public ToDoTask? SelectedTask
        {
            get => _selectedTask;
            set
            {
                _selectedTask = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }
        public ICommand UpdateTaskCommand { get; }

        public TaskViewModel()
        {
            Tasks = new ObservableCollection<ToDoTask>();
            AddTaskCommand = new RelayCommand(AddTask);
            DeleteTaskCommand = new RelayCommand(DeleteTask, CanDeleteTask);
            UpdateTaskCommand = new RelayCommand(UpdateTask, CanUpdateTask);
        }

        private void AddTask()
        {
            var newTask = new ToDoTask()
            {
                Id = Tasks.Count + 1, 
                Name = "New Task",
                Description = "Task Description",
                DueDate = DateTime.Now.AddDays(1),
                IsCompleted = false,
                Priority = 1
            };
            Tasks.Add(newTask);
        }

        private bool CanDeleteTask() => SelectedTask != null;

        private void DeleteTask()
        {
            if (SelectedTask != null)
                Tasks.Remove(SelectedTask);
        }

        private bool CanUpdateTask() => SelectedTask != null;

        private void UpdateTask()
        {
            if (SelectedTask != null)
            {
                var task = Tasks.FirstOrDefault(t => t.Id == SelectedTask.Id);
                if (task != null)
                {
                    task.Name = SelectedTask.Name;
                    task.Description = SelectedTask.Description;
                    task.DueDate = SelectedTask.DueDate;
                    task.Priority = SelectedTask.Priority;
                    task.IsCompleted = SelectedTask.IsCompleted;
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged; 
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // RelayCommand class để giúp thực hiện ICommand
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool>? _canExecute; 
        public RelayCommand(Action execute, Func<bool>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute();
        public void Execute(object? parameter) => _execute();
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
