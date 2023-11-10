using EB_Run.Core;
using System;

namespace EB_Run.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

		public RelayCommand HomeViewCommand { get; set; }
		public RelayCommand TreinoViewCommand { get; set; }

		public HomeViewModel HomeVM{ get; set; }
        public TreinoViewModel TreinoVM { get; set; }
        private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set 
			{ 
				_currentView = value;
                OnPropertyChanged();
			}
		}

		public MainViewModel()
		{
			HomeVM = new HomeViewModel();
            TreinoVM = new TreinoViewModel();
            CurrentView = HomeVM;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeVM;
			});

            TreinoViewCommand = new RelayCommand(o =>
            {
                CurrentView = TreinoVM;
            });

        }


	}
}
