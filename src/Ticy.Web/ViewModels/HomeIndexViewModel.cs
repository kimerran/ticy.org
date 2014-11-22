using System.Collections.Generic;
using Ticy.Domain.Models;

namespace Ticy.Web.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ConthreadEntity> Entity { get; set; }
    }
}