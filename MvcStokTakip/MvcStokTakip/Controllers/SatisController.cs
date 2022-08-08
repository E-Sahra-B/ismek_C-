using MvcStokTakip.Models.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MvcStokTakip.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        StokMvcEntities db = new StokMvcEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_Satislar.ToList();
            return View(degerler);
        }
    }
}