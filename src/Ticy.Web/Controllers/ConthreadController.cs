using Likja.Conthread;
using System.Web.Mvc;
using Ticy.Domain.Models;
using Ticy.Web.ViewModels;

namespace Ticy.Web.Controllers
{
    [RoutePrefix("t")]
    public class ConthreadController : Controller
    {
        private IConthreadService<CodeThread> _conthreadService;

        public ConthreadController(IConthreadService<CodeThread> conthreadService)
        {
            _conthreadService = conthreadService;
        }

        [Route("{hashId}")]
        [HttpGet]
        public ActionResult Details(string hashId)
        {
            // convert hash id to id
            var id = hashId.ConvertToInt();

            // hashid is not correct format
            if (id == 0)
                return RedirectToAction("Index", "Home", new { err = "INCORRECT_HASHID" });

            var thread = _conthreadService.GetById(id);

            var vm = new ThreadDetailsViewModel
            {
                Entity = thread
            };

            return View(vm);
        }

        [Route("next")]
        public ActionResult Next(string id)
        {
            // id here is hashId

            var nextItem = _conthreadService.GetNext(id.ConvertToInt());

            return View();
        }

        [Route("prev")]
        public ActionResult Previous(string id)
        {
            var prevItem = _conthreadService.GetPrevious(id.ConvertToInt());

            return View();
        }


    }
}