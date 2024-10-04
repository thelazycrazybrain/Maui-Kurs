using ShellApp.Pages;

namespace ShellApp {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();
            Routing.RegisterRoute("Todo/Detail", typeof(TodoDetailPage));
        }
    }
}
