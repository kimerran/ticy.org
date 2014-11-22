using Likja.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticy.Domain
{
    public class AuditableEntity : DomainEntity
    {
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("created_by")]
        public string CreatedBy { get; set; }

        [Column("updated_by")]
        public string UpdatedBy { get; set; }
    }
}
