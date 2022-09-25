using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("Medias")]
    public class Media : ModelBase, IEntity
    {
        

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(200)]
        public string FileSlug { get; set; }

        [StringLength(150)]
        public string Alt { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(300)]
        public string MediaUrl { get; set; }
    }
}
