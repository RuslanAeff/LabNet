using LabNet.DataBase;

namespace LabNet.ViewModels.Products
{
    public class ListViewModel
    {
        public ListViewModel(int id, string name, string content, decimal price)
        {
            Id = Id;
            Name = Name;
            Content = Content;
            Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
    }
}
