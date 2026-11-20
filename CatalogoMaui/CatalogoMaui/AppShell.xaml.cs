using CatalogoMaui.Views;
using Microsoft.Maui.Controls;

namespace CatalogoMaui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("producto-detalle", typeof(ProductoDetallePage));
    }
}
