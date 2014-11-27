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

        [Column("user_id")]
        public int UserId { get; set; }

        [NotMapped]
        public string LanguageClass
        {
            get
            {
                return Language.ToString().ToLower();
            }
        }

        [NotMapped]
        public string UrlTitle
        {
            get
            {
                if (Title.Length > 30)
                {
                    return Title.Substring(0, 30).ToLower().Replace(' ', '-');
                }

                return Title.ToLower().Replace(' ', '-');
            }
        }

    }
}
