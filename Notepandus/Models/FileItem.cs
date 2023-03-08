using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace Notepandus.Models {
    public enum FileTypes { SysDrive, Drive, BackFolder, Folder, FILE }

    public class FileItem {
        public FileItem(string icon, FileTypes type, string name) {
            Type = type;
            Name = name;

            var app = Application.Current;
            if (app == null) return; // Такого просто не бывает, но надо ;'-}
            var ress = app.Resources;
            var img = (Image?) ress[icon];
            if (img == null) return;
            Icon = (Bitmap?) img.Source;
        }
        public Bitmap? Icon { get; }
        public FileTypes Type { get; }
        public string Name { get; }
    }
}
