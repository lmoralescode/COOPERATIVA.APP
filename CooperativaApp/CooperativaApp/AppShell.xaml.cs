namespace CooperativaApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    public void ActivarMenu()
    {
        OpcionMenu.IsVisible = true;
        OpcionSocios.IsVisible = true;
        OpcionAhorros.IsVisible = true;
        OpcionPrestamos.IsVisible = true;
        OpcionPagos.IsVisible = true;
        //OpcionCerrarSesion.IsVisible = true;

        FlyoutBehavior = FlyoutBehavior.Flyout;
    }

    public void DesactivarMenu()
    {
        OpcionMenu.IsVisible = false;
        OpcionSocios.IsVisible = false;
        OpcionAhorros.IsVisible = false;
        OpcionPrestamos.IsVisible = false;
        OpcionPagos.IsVisible = false;
        //OpcionCerrarSesion.IsVisible = false;

        FlyoutBehavior = FlyoutBehavior.Disabled;
    }

    private async void OnCerrarSesionClicked(
        object sender, EventArgs e)
    {
        DesactivarMenu();
        await GoToAsync("//inicio");
    }
}