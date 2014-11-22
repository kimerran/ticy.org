using System.Collections.Generic;
using System.Web.Http;
using Ticy.Api.Conthread;
using Ticy.Domain.Models;

namespace Ticy.Web.Controllers.ApiControllers
{
    [RoutePrefix("api/t")]
    public class ConthreadApiController : ApiController
    {
        private IConthreadService _conthreadService;

        public ConthreadApiController(IConthreadService conthreadService)
        {
            _conthreadService = conthreadService;
        }

        [Route("")]
        public IEnumerable<ConthreadEntity> Get()
        {
            return _conthreadService.GetAll();
        }

    }
}
