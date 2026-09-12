C# WPF To Do List
Projeto de estudo em C# (.NET/WPF): uma aplicação de lista de tarefas para desktop. A lógica de funcionamento é implementada em C#, enquanto a interface é construída em WPF/XAML.
Tecnologias
C#, .NET, WPF, XAML.
Estrutura
```
MyToDoList/
├── Models/
├── Views/
├── Resources/
│   ├── ProjectDictionary.xaml
│   ├── ImageDictionary.xaml
│   └── Assets/
├── App.xaml
├── MainWindow.xaml
```
Funcionalidades
Cadastro de tarefas por meio de uma janela modal (AddTaskWindow), com comunicação de dados entre janelas via propriedade pública. Estilos customizados (TextBox arredondado com placeholder simulado, botões com imagem e efeitos de hover) centralizados em ResourceDictionaries próprios.
Próximas etapas
Modelo de tarefa, lista de tarefas com ObservableCollection, remoção/conclusão de itens, persistência em arquivo e futura migração para MVVM.
Projeto em desenvolvimento contínuo como estudo de C# e WPF.
