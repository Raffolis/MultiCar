using MultiCar.Pages;

namespace MultiCar;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();//new NavigationPage(new LoginPage());
    }
}
