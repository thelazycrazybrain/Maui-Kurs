using MvvmApp.ViewModels;

namespace MvvmApp.Pages;

public partial class TodoDetailPage : ContentPage {
    public TodoDetailPage(TodoDetailViewModel viewModel) {
        BindingContext = viewModel;
        InitializeComponent();
    }
}