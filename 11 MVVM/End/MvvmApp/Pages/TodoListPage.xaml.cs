using MvvmApp.ViewModels;

namespace MvvmApp.Pages;

public partial class TodoListPage : ContentPage {
    public TodoListPage(TodoListViewModel viewModel) {
        BindingContext = viewModel;
        InitializeComponent();
    }
}