using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MyToDoList;

namespace MyToDoList.Services
{    
    public class NewTaskAdditionValidation
    {        
        public void ValidateNewTask(AddTaskWindow addTaskWindow)
        {

            string NewTask = addTaskWindow.NewTask;
            if (string.IsNullOrWhiteSpace(NewTask))
            {
                MessageBox.Show("Please, type some task here.");
            }
            else
            {                
                addTaskWindow.Close();
            }
        }

    }
}
