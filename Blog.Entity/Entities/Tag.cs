using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("Tags")]
    public class Tag : ModelBase, IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(60)]
        public string MetaTitle { get; set; }

        [StringLength(160)]
        public string MetaDescription { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        [StringLength(80)]
        public string Slug { get; set; }
    }
}
