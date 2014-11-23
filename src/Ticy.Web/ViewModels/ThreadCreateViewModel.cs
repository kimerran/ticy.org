using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Ticy.Domain.Enums;
using Ticy.Domain.Models;

namespace Ticy.Web.ViewModels
{
    public class ThreadCreateViewModel
    {
        public CodeThread Entity { get; set; }

        [AllowHtml]
        [Required]
        public string ThreadContent { get; set; }

        public SyntaxLanguageType Language { get; set; }
    }
}