namespace MultiCar.Pages;

public partial class InscricaoPage : ContentPage
{
    public InscricaoPage()
    {
        InitializeComponent();
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        // Aqui voc� pode adicionar a l�gica para validar e cadastrar o usu�rio
        await DisplayAlert("Cadastro", "Usu�rio cadastrado com sucesso!", "OK");

        // Ap�s o cadastro, redireciona para a tela de login
        await Navigation.PopAsync();
    }

    private async void tapEntrar_Tapped(object sender, EventArgs e)
    {
        // Redireciona para a tela de login
        await Navigation.PopAsync();
    }
}
