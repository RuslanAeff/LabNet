using LabNet.DataBase.Models;

namespace LabNet.DataBase
{
    public class DBContext
    {
        public static int _productID;
       


        public static List<Product> _products = new List<Product>
        {
            new Product ("Product1","Cont", 555),
            new Product ("Product2","Cont", 666),
            new Product ("Product3","Cont", 777),
        }; 
    }
}
