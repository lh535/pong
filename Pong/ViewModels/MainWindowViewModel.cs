using ReactiveUI;
namespace Pong.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    ViewModelBase currentView;

    public MainWindowViewModel()
    {
        CurrentView = new MainMenuViewModel();
    }

    public ViewModelBase CurrentView 
    {
        get => currentView;
        private set => this.RaiseAndSetIfChanged(ref currentView, value);
    }

    public void StartGame() 
    {
        CurrentView = new GameViewModel();
    }
}
