using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("ContentTags")]
    public class ContentTag : ModelBase, IEntity
    {
        

        public int ContentId { get; set; }

        public int TagId { get; set; }
    }
}
