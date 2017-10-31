namespace VisualizadorDePdfs.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        string _Uri;

        public string Uri
        {
            get { return _Uri; }
            set
            {
                SetValue(ref _Uri, value);
                OnPropertyChanged(nameof(_Uri));
            }
        }

        public MainViewModel()
        {
            Uri = @"https://developer.xamarin.com/recipes/cross-platform/xamarin-forms/controls/display-pdf/offline.pdf";
        }
    }
}
