using Likja.Conthread;
using System.Linq;
using System.Web.Mvc;
using Ticy.Domain.Models;
using Ticy.Web.ViewModels;

namespace Ticy.Web.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        private IConthreadService<CodeThread> _conthreadService;

        public HomeController(IConthreadService<CodeThread> conthreadService)
        {
            _conthreadService = conthreadService;
        }

        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            var latestThreads = _conthreadService.GetAll().ToList()
               .OrderByDescending(o => o.Id).Take(5);

            latestThreads.ToList().ForEach(x =>
            {
               if (x.Content.Length > 300)
                {
                    x.Content = x.Content.Substring(0, 300);
                }
            });

            var vm = new HomeIndexViewModel
            {
                Entity = latestThreads
            };

            return View(vm);
        }

        [Route("new")]
        [HttpGet]
        public ActionResult New(string key = "")
        {
            // don't allow adding from public
            if (key != "ticyorg")
                return RedirectToAction("Index");            

            var vm = new ThreadCreateViewModel
            {
                Entity = new CodeThread()
            };
            return View(vm);
        }

        [Route("new")]
        [HttpPost]
        public ActionResult Create(ThreadCreateViewModel vm)
        {
           // if (!ModelState.IsValid) return Redirec

            // get the entity from the vm and save it

            var entity = vm.Entity;
            entity.Title = entity.Title.Trim();
            entity.Content = vm.ThreadContent.Trim();
            
            var newId = _conthreadService.Save(entity);

            return RedirectToAction("Details", "Conthread", new { hashId = newId.ConvertToHash() });
        }

        public ActionResult NotFound()
        {
            return View();
        }

    }
}