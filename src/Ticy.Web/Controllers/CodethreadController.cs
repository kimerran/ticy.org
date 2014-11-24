using Likja.Conthread;
using System.Web.Mvc;
using Ticy.Domain.Models;
using Ticy.Web.ViewModels;

namespace Ticy.Web.Controllers
{
    [RoutePrefix("t")]
    public class CodethreadController : Controller
    {
        private IConthreadService<CodeThread> _conthreadService;

        public CodethreadController(IConthreadService<CodeThread> conthreadService)
        {
            _conthreadService = conthreadService;
        }

        [HttpGet]
        [Route("next")]
        public ActionResult Next(string id)
        {
            var nextItem = _conthreadService.GetNext(id.ConvertToInt(Constants.HASH_SALT));

            if (nextItem == null)
                return RedirectToAction("Index", "Home", new { err = "NO_MORE_NEXT_ITEMS" });

            return RedirectToAction("Details", "Codethread",
                new
                {
                    hashId = nextItem.Id.ConvertToHash(Constants.HASH_SALT),
                    title = nextItem.UrlTitle
                });
        }

        [HttpGet]
        [Route("prev")]
        public ActionResult Previous(string id)
        {
            var prevItem = _conthreadService.GetPrevious(id.ConvertToInt(Constants.HASH_SALT));

            if (prevItem == null)
                return RedirectToAction("Index", "Home", new { err = "NO_MORE_PREV_ITEMS" });

            return RedirectToAction("Details", "Codethread",
                new
                {
                    hashId = prevItem.Id.ConvertToHash(Constants.HASH_SALT),
                    title = prevItem.UrlTitle
                });
        }

        [Route("{hashId}/{title}")]
        [HttpGet]
        public ActionResult Details(string hashId, string title = "")
        {
            // convert hash id to id
            var id = hashId.ConvertToInt(Constants.HASH_SALT);

            // hashid is not correct format
            if (id == 0)
                return RedirectToAction("Index", "Home", new { err = "INCORRECT_HASHID" });

            var thread = _conthreadService.GetById(id);

            var vm = new ThreadDetailsViewModel
            {
                Entity = thread
            };

            return View("Details", vm);
        }
    }
}