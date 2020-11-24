using EnvWindows7.Données;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace EnvWindows7
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class DepartementsPage : Page
    {
        private Regions listRegions = new Regions();
        private Region regionReceived;
        private Departement departementSelect;
        public DepartementsPage()
        {
            this.InitializeComponent();
            listRegions.chargermentRegions();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            regionReceived = (Region)Application.Current.Resources["RegionSelected"];
            listeDepartements.DataContext = regionReceived.ListDepart;

        }
        private void listeDepartements_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            departementSelect = (Departement)listeDepartements.SelectedItem;
            Application.Current.Resources["DepartementSelect"] = departementSelect;
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(InfoDepartementPage));
            BoutonRetour.IsEnabled = this.Frame.CanGoBack;
        }

        private void BoutonRetour_Click(object sender, RoutedEventArgs e)
        {
            OnRetourRequested();
        }

        private bool OnRetourRequested()
        {
            if(this.Frame.CanGoBack)
            {
                this.Frame.GoBack();

                return true;
            }

            return false;
        }
    }
}
