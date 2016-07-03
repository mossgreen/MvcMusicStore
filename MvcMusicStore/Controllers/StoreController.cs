using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {

        //We’ll use this “Index” method to implement our 
        //listing page that lists all genres in our music store.
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }


        //GET: /Store/Browse
        public string Browse()
        {
            return "Hello from store.browse()";
        }

        //GET: /Store/Details
        public string Details()
        {
            return "hello fro Store.Details()";
        }
    }
}