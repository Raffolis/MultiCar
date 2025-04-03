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
            // A��o ao marcar/desmarcar a checkbox
            bool isChecked = e.Value;
            DisplayAlert("Checkbox", isChecked ? "Lembrar de mim ativado" : "Lembrar de mim desativado", "OK");
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            // A��o ao clicar no bot�o de login
            DisplayAlert("Login", "Bot�o de login pressionado!", "OK");
        }

        private void tapCriarConta_Tapped(object sender, EventArgs e)
        {
            // A��o ao clicar no link "Clique aqui"
            DisplayAlert("Criar Conta", "Voc� clicou para criar uma conta!", "OK");
        }
    }
}
