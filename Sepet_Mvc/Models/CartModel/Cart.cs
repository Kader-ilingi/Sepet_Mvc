namespace Sepet_Mvc.Models.CartModels
{
    public class Cart//işlem metotlarını dahil edecek
    {
        //Dictionary<>--özünde jenerictir//Dictionary ise anahtar-değer ister
        //public Cart()
        //{
        //    Plakalar.Add(34, "İstanbul");
        //}
        //public Dictionary<int,string> Plakalar=new Dictionary<int,string>();
        public Dictionary<int,CartItem> myCart=new Dictionary<int, CartItem>();//list sadece değer kabul ediyor
    }
}
