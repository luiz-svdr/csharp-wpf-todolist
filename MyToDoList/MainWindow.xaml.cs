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

namespace MyToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddTask_Click(object sender, RoutedEventArgs e)
        {
            var newTaskWindow = new AddTaskWindow();
            newTaskWindow.Owner = this;
            newTaskWindow.ShowDialog();
            string taskText = newTaskWindow.NewTask;

            //TaskDisplay.Text = taskText;
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}