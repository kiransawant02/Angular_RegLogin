using Proj1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj1.Controllers
{
    public class DataController : Controller
    {
        public JsonResult UserLogin(LoginData d)
        {
            using (Connection dc = new Connection())
            {
                var user = dc.Users.Where(a => a.UserName.Equals(d.UserName) && a.Password.Equals(d.Password)).FirstOrDefault();
                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

    }
}