using System.Collections.Generic;
using Ticy.Domain.Models;

namespace Ticy.Web.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<CodeThread> Entity { get; set; }
    }
}