namespace WpfApp1.Model
{
    public class Item
    {
        public string ElementName { get; set; }
        public bool IsSelected { get; set; }
        public bool IsMetal { get; set; }
    }

    public class Metals
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}