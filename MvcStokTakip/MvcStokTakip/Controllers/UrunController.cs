using MvcStokTakip.Models.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MvcStokTakip.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        StokMvcEntities db = new StokMvcEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_Urunler.ToList();
            return View(degerler);
        }
    }
}