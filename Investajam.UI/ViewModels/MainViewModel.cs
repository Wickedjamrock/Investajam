using System.Windows.Input;
using ReactiveUI;
using Investajam.Views;

namespace Investajam.Investajam.UI.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public ICommand ShowStartViewCommand { get; }
        // public ICommand ShowDeckungsbeitragCommand { get; }
        // public ICommand ShowInvestitionsrechnungCommand { get; }

        private object? _currentView;
        public object? CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }

        public MainViewModel()
        {
            ShowStartViewCommand = ReactiveCommand.Create(ShowStartView);
            // ShowDeckungsbeitragCommand = ReactiveCommand.Create(ShowDeckungsbeitrag);
            // ShowInvestitionsrechnungCommand = ReactiveCommand.Create(ShowInvestitionsrechnung);

            // Starte mit StartView
            ShowStartView();
        }

        private void ShowStartView()
        {
            CurrentView = new StartView();
        }
    }
}
