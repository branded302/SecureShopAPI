//using SecureShopAPI.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace SecureShopAPI.WebShops
//{
//    public class MockWebShop : Iwebshop
//    {
//        private List<WebShop> webshops = new List<WebShop>()
//        {
//            new WebShop()
//            {
//                id = Guid.NewGuid(),
//                Name = "Shop 1"
//            },
//            new WebShop()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Shop 2"
//            },
//            new WebShop()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Shop 3"
//            }
//        };


//        public WebShop AddWebShop(WebShop webshop)
//        {
//            webshop.Id = Guid.NewGuid();
//            webshops.Add(webshop);
//            return webshop;
//        }

//        public void DeleteWebShop(WebShop webshop)
//        {
//            webshops.Remove(webshop);
//        }

//        public WebShop EditWebShop(WebShop webshop)
//        {
//            var webshopexist = GetWebShop(webshop.Id);
//            webshopexist.Name = webshop.Name;
//            return webshopexist;
//        }

//        public WebShop GetWebShop(Guid Id)
//        {
//            return webshops.SingleOrDefault(x => x.Id == Id);
//        }

//        public List<WebShop> GetWebShops()
//        {
//            return webshops;
//        }
//    }
//}
