using Microsoft.Maui.Controls;
using Microsoft.Maui.Dispatching;

namespace MultiCar.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        bool isChecked = e.Value;
        MainThread.InvokeOnMainThreadAsync(async () =>
        {
            await DisplayAlert("Checkbox", isChecked ? "Lembrar de mim ativado" : "Lembrar de mim desativado", "OK");
        });
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        if (DeviceInfo.Platform == DevicePlatform.MacCatalyst)
            return;

        await DisplayAlert("Login", "Botão de login pressionado!", "OK");
    }

    private async void tapCriarConta_Tapped(object sender, EventArgs e)
    {
        if (DeviceInfo.Platform == DevicePlatform.MacCatalyst)
            return;

        await Navigation.PushAsync(new InscricaoPage());
    }
}
