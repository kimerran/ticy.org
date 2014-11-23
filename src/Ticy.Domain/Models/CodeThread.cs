using Likja.Conthread;
using System.ComponentModel.DataAnnotations.Schema;
using Ticy.Domain.Enums;

namespace Ticy.Domain.Models
{
    [Table("codethread")]
    public class CodeThread : Conthread
    {      
        [Column("lang")]
        public SyntaxLanguageType Language { get; set; }
         
        [NotMapped]
        public string LanguageClass
        {
            get
            {
                return Language.ToString().ToLower();
            }
        }
    }
}
