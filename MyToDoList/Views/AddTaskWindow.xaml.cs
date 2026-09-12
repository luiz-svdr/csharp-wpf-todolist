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

namespace MyToDoList
{
    /// <summary>
    /// Lógica interna para AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        public string NewTask { get; private set; }

        public AddTaskWindow()
        {
            InitializeComponent();
        }

        private void AddTaskWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            string newTask = AddTaskTextBox.Text;  
            NewTask = newTask;
            this.Close();       

        }
        private void CancelTaskWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
