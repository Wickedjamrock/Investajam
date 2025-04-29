using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Investajam.UI.UserControls
{
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
            ProjektButton.Click += OnProjektButtonClick;
        }

        private void OnProjektButtonClick(object? sender, RoutedEventArgs e)
        {
            ProjektDropdown.IsVisible = !ProjektDropdown.IsVisible;
        }
    }
}
