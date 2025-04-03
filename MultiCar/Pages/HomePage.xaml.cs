using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MultiCar.Pages
{
    public partial class HomePage : ContentPage
    {
        public ICommand PesquisarCommand { get; }
        public ICommand LimparPesquisaCommand { get; }

        public HomePage()
        {
            InitializeComponent();

            PesquisarCommand = new Command<string>(Pesquisar);
            LimparPesquisaCommand = new Command(LimparPesquisa);

            BindingContext = this;
        }

        private void Pesquisar(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                Console.WriteLine($"Pesquisando por: {query}");
            }
        }

        private void LimparPesquisa()
        {
            searchBar.Text = string.Empty;
        }
    }
}
