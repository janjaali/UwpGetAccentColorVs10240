using System.Diagnostics;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace UwpGetAccentColorVs10240
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            logAccentColor();
        }

        private void logAccentColor()
        {
            var uiSettings = new UISettings();
            var accentColor = uiSettings.GetColorValue(UIColorType.Accent);
            Debug.WriteLine($"Current Accent Color: {accentColor}");
        }
    }
}
