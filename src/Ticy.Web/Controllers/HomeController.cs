using Likja.Conthread;
using System.Linq;
using System.Web.Mvc;
using Ticy.Api.User;
using Ticy.Domain.Models;
using Ticy.Web.ViewModels;

namespace Ticy.Web.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        private IConthreadService<CodeThread> _conthreadService;
        private IUserService _userService;

        public HomeController(IConthreadService<CodeThread> conthreadService, IUserService userService)
        {
            _conthreadService = conthreadService;
            _userService = userService;
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
                    x.Content = string.Format("{0}...", x.Content.Substring(0, 300));
            });

            var vm = new HomeIndexViewModel
            {
                Entity = latestThreads
            };

            return View(vm);
        }

        [Route("new")]
        [HttpGet]
        public ActionResult New()
        {
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
            var entity = vm.Entity;
            entity.Title = entity.Title.Trim();
            entity.Content = vm.ThreadContent.Trim();

            // check if user exists
            var user = _userService.FindByEmail(vm.Email);

            if (user == null)
            {
                // create user
                user = new Domain.Models.User
                {
                    Email = vm.Email
                };

                user.Id = _userService.Save(user);
            }

            entity.UserId = user.Id; 

            var newId = _conthreadService.Save(entity);

            return RedirectToAction("Details", "Codethread",
                new
                {
                    hashId = newId.ConvertToHash(),
                    title = entity.Title
                });
        }

        public ActionResult NotFound()
        {
            return View();
        }

    }
}