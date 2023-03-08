using Avalonia.Controls;
using Avalonia.Interactivity;
using Notepandus.ViewModels;

namespace Notepandus.Views {
    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void DoubleTap(object sender, RoutedEventArgs e) {
            var mwvm = (MainWindowViewModel?) DataContext;
            if (mwvm == null) return;
            mwvm.DoubleTap();
        }
    }
}