using MyToDoList.Services;
using System.Windows;

namespace MyToDoList
{
    public partial class AddTaskWindow : Window
    {
        public string NewTask { get; private set; }

        public AddTaskWindow()
        {
            InitializeComponent();
        }

        private void AddTaskWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            NewTask = AddTaskTextBox.Text;

            NewTaskAdditionValidation validation = new NewTaskAdditionValidation();
            validation.ValidateNewTask(this);
        }

        private void CancelTaskWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}