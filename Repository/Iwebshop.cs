using SecureShopAPI.Models;
using System;
using System.Collections.Generic;


namespace SecureShopAPI.WebShops
{
    public interface Iwebshop
    {
        List<WebShop> GetWebShops();
        WebShop GetWebShop(int? id);
        WebShop AddWebShop(WebShop webshop);
        void DeleteWebShop(WebShop webshop);

        WebShop EditWebShop(WebShop webshop);
    }
}
