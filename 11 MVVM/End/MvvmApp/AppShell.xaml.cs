using MvvmApp.Pages;

namespace MvvmApp {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();
            Routing.RegisterRoute("Todos/Detail", typeof(TodoDetailPage));
        }
    }
}
