using MvcStokTakip.Models.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MvcStokTakip.Controllers
{
    public class MusteriController : Controller
    {
        StokMvcEntities db = new StokMvcEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_musteriler.ToList();
            return View(degerler);
        }
    }
}