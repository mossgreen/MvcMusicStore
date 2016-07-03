﻿using System;
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


        //GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {

           /* We’re using the HttpUtility.HtmlEncode utility method to sanitize the user input. 
                This prevents users from injecting Javascript into our View 
                with a link like / Store / Browse ? Genre =< script > window.location =
                ’http://hackersite.com’</script>. */
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        //GET: /Store/Details
        public string Details(int id)
        {
            string message = "Store.details, ID =" + id;
            return message;
        }
    }
}