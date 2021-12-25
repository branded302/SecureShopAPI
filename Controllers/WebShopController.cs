using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureShopAPI.Models;
using SecureShopAPI.WebShops;
using System;


namespace SecureShopAPI.Controllers
{
    
    [ApiController]
    [AllowAnonymous]
    public class WebShopController : ControllerBase
    {
        private Iwebshop _webshop;
        public WebShopController(Iwebshop webshop)
        {
            _webshop = webshop;
        }

        [HttpGet]

        [Route("api/[controller]")]
        public IActionResult GetWebShops()
        {
            return Ok(_webshop.GetWebShops());
        }


        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetWebShop(int? id)
        {
            var webshop = _webshop.GetWebShop(id);

            if(webshop != null)
            {
                return Ok(webshop);
            }
            return NotFound("No data found");
            
        }




        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddWebShop(WebShop webshop)
        {
            _webshop.AddWebShop(webshop);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + webshop.id, webshop);

        }


        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteWebShop(int id)
        {
            var webshop = _webshop.GetWebShop(id);
            if(webshop != null)
            {
                _webshop.DeleteWebShop(webshop);
                return Ok();
            }
            return NotFound("Web Shop not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditWebShop(int id, WebShop webshop)
        {
            var webshopexist = _webshop.GetWebShop(id);
            if (webshopexist != null)
            {
                webshop.id = webshopexist.id;
                _webshop.EditWebShop(webshop);
                return Ok();
            }
            return NotFound("Web Shop not found");
        }
    }
}
