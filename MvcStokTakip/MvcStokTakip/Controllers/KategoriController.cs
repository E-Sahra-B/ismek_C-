using MvcStokTakip.Models.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MvcStokTakip.Controllers
{
    public class KategoriController : Controller
    {
        StokMvcEntities db = new StokMvcEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_kategoriler.ToList();
            return View(degerler);
        }
    }
}