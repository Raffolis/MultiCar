using MultiCar.Pages;

namespace MultiCar;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        ConfigureShell();
    }

    private void ConfigureShell()
    {
        var homePage = new HomePage();
        var buscarPage = new BuscaPage();
        var cadastroPage = new CadastroPage();
        var perfilPage = new PerfilPage();

        var tabBar = new TabBar
        {
            Items =
            {
                new ShellContent { Title = "Home", Icon = "home.png", Content = homePage },
                new ShellContent { Title = "Buscar", Icon = "pesquisar.png", Content = buscarPage },
                new ShellContent { Title = "Cadastrar", Icon = "add.png", Content = cadastroPage },
                new ShellContent { Title = "Perfil", Icon = "perfil.png", Content = perfilPage }
            }
        };

        Items.Add(tabBar);
    }
}
