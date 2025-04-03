namespace MultiCar.Pages
{
    public partial class InscricaoPage : ContentPage
    {
        public InscricaoPage()
        {
            InitializeComponent();
        }

        private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // Ação ao marcar/desmarcar a checkbox
            bool isChecked = e.Value;
            DisplayAlert("Checkbox", isChecked ? "Lembrar de mim ativado" : "Lembrar de mim desativado", "OK");
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            // Ação ao clicar no botão de login
            DisplayAlert("Login", "Botão de login pressionado!", "OK");
        }

        private void tapCriarConta_Tapped(object sender, EventArgs e)
        {
            // Ação ao clicar no link "Clique aqui"
            DisplayAlert("Criar Conta", "Você clicou para criar uma conta!", "OK");
        }
    }
}
