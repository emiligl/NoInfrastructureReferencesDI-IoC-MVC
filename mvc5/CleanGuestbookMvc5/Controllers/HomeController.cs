using System.Web.Mvc;
using Core.Interfaces;
using Core.Bll;

namespace CleanGuestbookMvc5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGuestbookRepository _guestbookRepository;
        private readonly ILogger _logger;

        public HomeController(IGuestbookRepository guestbookRepository, ILogger logger)
        {
            _guestbookRepository = guestbookRepository;
            _logger = logger;
        }

        public ActionResult Index()
        {
            UtilidadesBLL util = new UtilidadesBLL(_logger);
            util.DoTask();

            var model = _guestbookRepository.GetById(1);

            ViewBag.Message = model.Name;

            return View();
        }
    }
}