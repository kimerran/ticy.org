using System.Web.Mvc;
using Ticy.Api.Conthread;
using Ticy.Domain.Extensions;
using Ticy.Domain.Models;
using Ticy.Web.ViewModels;

namespace Ticy.Web.Controllers
{
    [RoutePrefix("t")]
    public class ConthreadController : Controller
    {
        private IConthreadService _conthreadService;

        public ConthreadController(IConthreadService conthreadService)
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
            if (id == 0) return RedirectToAction("Index", "Home", new { err = "INCORRECT_HASHID" });

            var thread = _conthreadService.GetById(id);

            var vm = new ThreadDetailsViewModel
            {
                Entity = thread
            };

            return View(vm);
        }
    }
}