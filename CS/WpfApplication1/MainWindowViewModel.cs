using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;
// ...

namespace WpfApplication1 {
    public class MainWindowViewModel {
        string buttonContent = "Press me!";
        public string ButtonContent {
            get { return buttonContent; }
            set {
                buttonContent = value;
                RaisePropertyChanged("ButtonContent");
            }
        }

        public ICommand DoWork { get; private set; }

        public MainWindowViewModel() {
            DoWork = new DelegateCommand<object>(ignore => MessageBox.Show("The custom button has been clicked."));
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string propertyName) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}