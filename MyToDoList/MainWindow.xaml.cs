using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MyToDoList
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<TaskItem> Tasks { get; set; } = new ObservableCollection<TaskItem>();

        public MainWindow()
        {
            InitializeComponent();
            TaskListControl.ItemsSource = Tasks;
        }

        private void BtnAddTask_Click(object sender, RoutedEventArgs e)
        {
            var newTaskWindow = new AddTaskWindow();
            newTaskWindow.Owner = this;
            newTaskWindow.ShowDialog();

            string taskText = newTaskWindow.NewTask;

            if (!string.IsNullOrWhiteSpace(taskText))
            {
                Tasks.Add(new TaskItem { Description = taskText });
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            var btnClicked = sender as Button;
            var taskToRemove = btnClicked.CommandParameter as TaskItem;

            if (taskToRemove != null)
            {
                Tasks.Remove(taskToRemove);
            }
        }
    }
}