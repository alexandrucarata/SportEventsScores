using TennisScore.Core;

namespace TennisScore.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TennisViewCommand { get; set; }
        public RelayCommand BasketballViewCommand { get; set; }
        public RelayCommand FootballViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public TennisViewModel TennisVm { get; set; }
        public BasketballViewModel BasketballVm { get; set; }
        public FootballViewModel FootballVm { get; set; }

        

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            private set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            TennisVm = new TennisViewModel();
            BasketballVm = new BasketballViewModel();
            FootballVm = new FootballViewModel();
            CurrentView = HomeVm;
            

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            TennisViewCommand = new RelayCommand(o =>
            {
                CurrentView = TennisVm;
            });

            BasketballViewCommand = new RelayCommand(o =>
            {
                CurrentView = BasketballVm;
            });

            FootballViewCommand = new RelayCommand(o =>
            {
                CurrentView = FootballVm;
            });
        }
    }
}
