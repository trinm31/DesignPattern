using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopeFacade.GetInstance().BuyProductByCashWithFreeShipping("nmtri31082001@gmail.com");
            ShopeFacade.GetInstance().BuyProductByPaypalWithStandardShipping("0342288600","nmtri31082001@gmail.com");
        }
    }
}