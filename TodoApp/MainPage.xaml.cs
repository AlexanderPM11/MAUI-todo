using TodoApp.Views;

namespace TodoApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToDetailPage_Clicked(object sender, EventArgs e)
        {
            // Navegación usando Shell
            await Shell.Current.GoToAsync(nameof(DetailPage));
        }
    }
}
