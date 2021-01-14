using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using muxc = Microsoft.UI.Xaml.Controls;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BinaryCrypt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings =
          Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
        Windows.Storage.ApplicationData.Current.LocalFolder;

        public MainPage()
        {
         

            this.InitializeComponent();
         
            /*if (localSettings.Values["Theme"] == null)
            {
                
            }
            else if (localSettings.Values["Theme"].ToString() == "Light")
            {
                App.Current.RequestedTheme = ApplicationTheme.Light;
                TextTitle.Text = App.Current.RequestedTheme.ToString();
            }
            else if (localSettings.Values["Theme"].ToString() == "Dark")
            {
                App.Current.RequestedTheme = ApplicationTheme.Dark;
                TextTitle.Text = App.Current.RequestedTheme.ToString();
            }*/
            
            ApplicationView.PreferredLaunchViewSize = new Windows.Foundation.Size(480, 800);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

        }

        private void ThemeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           


            string Theme = ThemeBox.SelectedItem.ToString();
            if (Theme == "Dark")
            {
                localSettings.Values["Theme"] = "Dark";

                

            }
            else
            {

                localSettings.Values["Theme"] = "Light"; 
                

            }
        }

        private void SourceBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SourceBox.Text == "") {
                TargetBox.IsEnabled = false;

            }
            else {
                
                if (SourceComboBox.SelectedItem != null) { 
                string selected = SourceComboBox.SelectedItem.ToString();
            int zwischenergebnis = 0;
            if (selected.ToString() == "Decimal")
            {

            }
            if (selected.ToString() == "Binary")
            {
                
                int u = selected.ToString().Length;
                int indexpos = 0;
                while (u >= 0){
                    string val = selected.ToString()[u].ToString();
                    zwischenergebnis = (int)(zwischenergebnis + Math.Pow(int.Parse(val), indexpos));
                    indexpos += 1;
                    u -= 1;
                }
            }
            TargetBox.IsEnabled = true;
            TargetBox.Text = zwischenergebnis.ToString();

        }
            }
        }
    }
}
