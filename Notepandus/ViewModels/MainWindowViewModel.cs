using Notepandus.Models;
using System.Collections.ObjectModel;

namespace Notepandus.ViewModels {
    public class MainWindowViewModel: ViewModelBase {
        private readonly ObservableCollection<FileItem> fileList = new() {
            new FileItem("yeah", "Meow"),
            new FileItem("yeah", "Woof"),
            new FileItem("yeah", "Boom")
        };
        public ObservableCollection<FileItem> FileList { get => fileList; }
    }
}