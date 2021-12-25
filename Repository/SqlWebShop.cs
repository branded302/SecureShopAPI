
using SecureShopAPI.Data;
using SecureShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecureShopAPI.WebShops
{
    public class SqlWebShop : Iwebshop
    {
        private readonly WebShopContext _context;

        public SqlWebShop(WebShopContext context)
        {
            _context = context;
        }
        public WebShop AddWebShop(WebShop webshop)
        {
            throw new NotImplementedException();
        }

        public void DeleteWebShop(WebShop webshop)
        {
            throw new NotImplementedException();
        }

        public WebShop EditWebShop(WebShop webshop)
        {
            throw new NotImplementedException();
        }

        public WebShop GetWebShop(int? id)
        {
            var webshop= _context.WebShopes.Find(id);
            return webshop;
        }

        

        public List<WebShop> GetWebShops()
        {
            return _context.WebShopes.ToList();
        }
        
    }
}
