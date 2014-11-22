using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ticy.Domain.Extensions;

namespace Ticy.Domain.Models
{
    [Table("thread")]
    public class ConthreadEntity : AuditableEntity
    {
        [Column("content")]
        public string Content { get; set; }

        [Column("title")]
        [Required]
        public string Title { get; set; }

        [Column("user_id")]
        public int CreatedByUserId { get; set; }

        [NotMapped]
        public string HashId
        {
            get
            {
                return Id.ConvertToHash();
            }
        }
    }
}
