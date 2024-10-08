namespace ShellApp.Pages;

[QueryProperty(nameof(Task), "Task")]
public partial class TodoDetailPage : ContentPage, IQueryAttributable {
    public TodoDetailPage() {
        BindingContext = this;
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query) {
        if (query.TryGetValue("Task", out var task) && task is string t) {
            Task = t;
        }
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