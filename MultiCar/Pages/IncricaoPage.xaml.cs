namespace MultiCar.Pages;

public partial class InscricaoPage : ContentPage
{
    public InscricaoPage()
    {
        InitializeComponent();
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        // Aqui você pode adicionar a lógica para validar e cadastrar o usuário
        await DisplayAlert("Cadastro", "Usuário cadastrado com sucesso!", "OK");

        // Após o cadastro, redireciona para a tela de login
        await Navigation.PopAsync();
    }

    private async void tapEntrar_Tapped(object sender, EventArgs e)
    {
        // Redireciona para a tela de login
        await Navigation.PopAsync();
    }
}
