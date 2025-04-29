using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Investajam.Investajam.UI.ViewModels;

namespace Investajam.UI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}