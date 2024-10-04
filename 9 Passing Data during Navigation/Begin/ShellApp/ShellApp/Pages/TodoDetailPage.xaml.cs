namespace ShellApp.Pages;

public partial class TodoDetailPage : ContentPage {
    public TodoDetailPage() {
        BindingContext = this;
        InitializeComponent();
    }

    private string _task;
    public string Task {
        get => _task;
        set {
            _task = value;
            OnPropertyChanged();
        }
    }


}