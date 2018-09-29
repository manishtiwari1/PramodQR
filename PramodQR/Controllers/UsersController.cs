using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace PramodQR.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /UsersController/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(string data)
        {
            string path = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                using (Bitmap bitMap = qrCode.GetGraphic(20))
                {
                    bitMap.Save(ms, ImageFormat.Png);
                    path = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }

            return Json(path, JsonRequestBehavior.AllowGet); ;
        }
        public ActionResult SearchUser(string searchData)
        {
            return View();
        }


    }
}
