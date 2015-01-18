using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco;

namespace AffordableInterior.CMS.Web.Controllers
{
    public class MySurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        //
        // GET: /MySurface/

        public ActionResult Index()
        {
            return View();
        }

    }
}
