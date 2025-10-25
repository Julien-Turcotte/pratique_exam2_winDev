using Examen2.Data;
using Examen2.ViewModels.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

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
        // TODO: Plusieurs options existent. Mais si vous utilisez un
        //          Button.Flyout voici un indice --> flyoutModification.ShowAt(sender as FrameworkElement);
    }

    private void TerminerModif(object sender, RoutedEventArgs e)
    {

    }
}
