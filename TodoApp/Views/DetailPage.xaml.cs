namespace TodoApp.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage()
    {
        InitializeComponent();
    }

    private async void GoBack_Clicked(object sender, EventArgs e)
    {
        // Volver atrás
        await Shell.Current.GoToAsync("..");
    }
}