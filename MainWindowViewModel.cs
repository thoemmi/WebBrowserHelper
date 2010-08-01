using System.ComponentModel;

namespace WebBrowserHelperDemo {
    public class MainWindowViewModel : INotifyPropertyChanged {
        private string _myHtml;

        public string MyHtml {
            get { return _myHtml; }
            set {
                if (_myHtml != value) {
                    _myHtml = value;
                    RaisePropertyChanged("MyHtml");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName) {
            var handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}