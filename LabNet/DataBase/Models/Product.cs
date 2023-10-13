using LabNet.ViewModels.Products;

namespace LabNet.DataBase.Models
{
    public class Product
    {
        public Product()
        {
                Id = ++DBContext._productID;
        }
        public Product(string name, string content, decimal price)
        {
            name = Name;
            content = Content; 
            price = Price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
    }
}
