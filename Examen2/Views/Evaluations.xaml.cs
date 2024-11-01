using Examen2.Data;
using Examen2.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Examen2.Views;

public sealed partial class Evaluations : Page
{
    public MainViewModelEvaluations ViewModel { get; }

    public Evaluations()
    {
        this.InitializeComponent();
        ViewModel = new MainViewModelEvaluations(new JeuxDataProvider());
        root.Loaded += Root_Loaded;
    }

    private void Root_Loaded(object sender, RoutedEventArgs e)
    {
        ViewModel.ChargerDonnees();
    }

    private void AjouterEvaluation(object sender, RoutedEventArgs e)
    {
        ViewModel.AjoutEvaluation();
        formAjout.Hide();
    }

    private void VoirFormModifEvaluation(object sender, RoutedEventArgs e)
    {
        this.modifForm.Visibility = Visibility.Visible;
    }

    private void TerminerModif (object sender, RoutedEventArgs e)
    {
        this.modifForm.Visibility = Visibility.Collapsed;
    }
}
