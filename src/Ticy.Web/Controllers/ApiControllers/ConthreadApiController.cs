using Likja.Conthread;
using System.Collections.Generic;
using System.Web.Http;
using Ticy.Domain.Models;

namespace Ticy.Web.Controllers.ApiControllers
{
    [RoutePrefix("api/t")]
    public class ConthreadApiController : ApiController
    {
        private IConthreadService<CodeThread> _conthreadService;

        public ConthreadApiController(IConthreadService<CodeThread> conthreadService)
        {
            _conthreadService = conthreadService;
        }

        [Route("")]
        public IEnumerable<CodeThread> Get()
        {
            return _conthreadService.GetAll();
        }

    }
}
