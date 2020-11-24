using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using EnvWindows7.Données;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace EnvWindows7
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class InfoDepartementPage : Page
    {
        private Regions listRegions = new Regions();
        private Departement departementReceived;
        public InfoDepartementPage()
        {
            this.InitializeComponent();
            listRegions.chargermentRegions();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            departementReceived = (Departement)Application.Current.Resources["DepartementSelect"];
            labelNom.Text = departementReceived.DepartementString;
            labelPopulation.Text = departementReceived.InfoPopulationString;
            labelSurface.Text = departementReceived.InfoSurfaceString;
            BoutonRetour.IsEnabled = this.Frame.CanGoBack;
        }

        private void BoutonRetour_Click(object sender, RoutedEventArgs e)
        {
            OnRetourRequested();
        }

        private bool OnRetourRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();

                return true;
            }

            return false;
        }
    }
}
