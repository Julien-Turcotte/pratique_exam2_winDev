using Examen2.Data;
using Examen2.ViewModels.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Examen2.Views;

public sealed partial class Jeux : Page
{
    public MainViewModelJeux ViewModel { get; }

    public Jeux()
    {
        this.InitializeComponent();
        ViewModel = new MainViewModelJeux(new JeuxDataProvider());
        root.Loaded += Root_Loaded;
    }

    private void Root_Loaded(object sender, RoutedEventArgs e)
    {
        ViewModel.ChargerDonnees();
    }
}
