using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Ticy.Domain.Enums;
using Ticy.Domain.Models;

namespace Ticy.Web.ViewModels
{
    public class ThreadCreateViewModel
    {
        private const string RequiredMessage = "This is required.";

        public CodeThread Entity { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = RequiredMessage)]
        public string ThreadContent { get; set; }

        public SyntaxLanguageType Language { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [EmailAddress(ErrorMessage = "Must be a valid e-mail address.")]
        public string Email { get; set; }
    }
}