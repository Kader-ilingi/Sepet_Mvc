namespace Sepet_Mvc.Models.ViewModels
{
    public class ProductViewModel
    {
        //anasyafada listelenecek olan ürünlerin ....'sı olur
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public string CategoryName { get; set; }
    }
}
