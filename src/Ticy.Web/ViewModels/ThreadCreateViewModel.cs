using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Ticy.Domain.Enums;
using Ticy.Domain.Models;

namespace Ticy.Web.ViewModels
{
    public class ThreadCreateViewModel
    {
        public ConthreadEntity Entity { get; set; }

        [AllowHtml]
        [Required]
        public string ThreadContent { get; set; }

        public SyntaxLanguage Language { get; set; }


        public IEnumerable<string> LanguageSelection
        {
            get
            {
                return EnumLists.SyntaxLanguages;
            }
        }

    }
}