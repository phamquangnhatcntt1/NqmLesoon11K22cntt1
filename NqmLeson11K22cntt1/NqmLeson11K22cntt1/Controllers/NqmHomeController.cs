using NqmLeson11K22cntt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NqmLeson11K22cntt1.Controllers
{
    public class NqmHomeController : Controller
    {
        
            public ActionResult NqmIndex()
            {
                // lấy thông tin từ session
                //ViewBag["tvcTaiKhoan"] = "";
                if (Session["NqmMember"] != null)
                {
                    ViewBag.nqmTaiKhoan = ((NqmTaiKhoan)Session["TvcMember"]).NqmFullName;
                }
                return View();
            }

            public ActionResult NqmAbout()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult NqmContact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        }
    }
