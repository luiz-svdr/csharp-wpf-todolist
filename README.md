# C# WPF To Do List

A study project in C# (.NET/WPF): a desktop to-do list application. Application logic is implemented in C#, while the interface is built with WPF/XAML.

## Technologies

C#, .NET, WPF, XAML.

## Structure

```
MyToDoList/
├── Models/
├── Views/
├── Services/
├── Resources/
│   ├── ProjectDictionary.xaml
│   ├── ImageDictionary.xaml
│   └── Assets/
├── App.xaml
├── MainWindow.xaml
```

## Features

Task creation through a modal window (AddTaskWindow), with input validation (Services/NewTaskAdditionValidation) and data communication between windows via a public property.

Dynamic task listing using ObservableCollection<TaskItem> and an ItemsControl with a DataTemplate, displaying each task as a card (Border + TextBlock) with a delete button, without manually repeating elements in XAML.

Custom styles (rounded TextBox with simulated placeholder, image-based buttons with hover effects, task cards) centralized in dedicated ResourceDictionaries.

## Next steps

Marking tasks as completed, file persistence, and a future migration to MVVM.

Project under continuous development as a C# and WPF study exercise.
