namespace Sepet_Mvc.Models.CartModels
{
    public class CartItem//fiziki sepetimiz 
    {
        public CartItem()
        {
            Quantity = 1;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? SubTotal
        {
            //readonly
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}
