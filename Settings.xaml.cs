using System;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Copy_Emoticons
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
        }

        // Navegação das páginas
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }

        private void clearFavs(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;

            if (settings.Containers.ContainsKey("Favoritos"))
            {
                if (settings.Containers["Favoritos"].Values != null)
                {
                    foreach (var favourites in settings.Containers["Favoritos"].Values)
                    {
                        settings.Containers["Favoritos"].Values.Remove(favourites.Key);
                    }

                    Button button = sender as Button;
                    string oldContent = (string)button.Content;
                                        
                    button.Content = "";
                    button.FontFamily = new FontFamily("Segoe MDL2 Assets");

                    DelayAction(1000, new Action(() => {
                        button.FontFamily = new FontFamily("Ebrima");
                        button.Content = oldContent;
                    }));
                }
            }
        }

        public static void DelayAction(int millisecond, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate

            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }

        // aplica cor na barra de status do windows


        // converte string HEX para Cor
        public Color ConvertStringToColor(String hex)
        {
            // Tira o # do codigo hex
            hex = hex.Replace("#", "");

            byte a = 255;
            byte r = 255;
            byte g = 255;
            byte b = 255;

            int start = 0;

            if (hex.Length == 8)
            {
                a = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                start = 2;
            }

            // Converte os caracteres RGB para bytes
            r = byte.Parse(hex.Substring(start, 2), System.Globalization.NumberStyles.HexNumber);
            g = byte.Parse(hex.Substring(start + 2, 2), System.Globalization.NumberStyles.HexNumber);
            b = byte.Parse(hex.Substring(start + 4, 2), System.Globalization.NumberStyles.HexNumber);

            return Color.FromArgb(a, r, g, b);
        }

        public static Brush ColorToBrush(string color) // color = "#E7E44D"
        {
            color = color.Replace("#", "");
            if (color.Length == 6)
            {
                return new SolidColorBrush(ColorHelper.FromArgb(255,
                    byte.Parse(color.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(4, 2), System.Globalization.NumberStyles.HexNumber)));
            }
            else
            {
                return null;
            }
        }
    }
}
