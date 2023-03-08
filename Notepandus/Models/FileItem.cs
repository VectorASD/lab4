namespace Notepandus.Models {
    public class FileItem {
        public FileItem(string icon, string name) {
            Icon = icon;
            Name = name;
        }
        public string Icon { get; }
        public string Name { get; }
    }
}
