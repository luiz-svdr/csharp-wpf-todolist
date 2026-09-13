C# WPF To Do List
Projeto de estudo em C# (.NET/WPF): uma aplicação de lista de tarefas para desktop. A lógica de funcionamento é implementada em C#, enquanto a interface é construída em WPF/XAML.
Tecnologias
C#, .NET, WPF, XAML.
Estrutura
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
Funcionalidades
Cadastro de tarefas por meio de uma janela modal (AddTaskWindow), com validação do campo de texto (Services/NewTaskAdditionValidation) e comunicação de dados entre janelas via propriedade pública.
Listagem dinâmica de tarefas com ObservableCollection<TaskItem> e um ItemsControl com DataTemplate, exibindo cada tarefa como um card (Border + TextBlock) com botão de remoção, sem repetição manual de elementos no XAML.
Estilos customizados (TextBox arredondado com placeholder simulado, botões com imagem e efeitos de hover, cards de tarefa) centralizados em ResourceDictionaries próprios.
Próximas etapas
Marcar tarefas como concluídas, persistência em arquivo e futura migração para MVVM.
Projeto em desenvolvimento contínuo como estudo de C# e WPF.
