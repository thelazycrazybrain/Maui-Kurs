using ShellApp.Pages;

namespace ShellApp {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();
            Routing.RegisterRoute("About", typeof(AboutPage));
        }

        private async void MenuItem_Clicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("About");
            FlyoutIsPresented = false;
        }
    }
}
