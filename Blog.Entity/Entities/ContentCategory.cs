using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("ContentCategories")]
    public class ContentCategory : ModelBase, IEntity
    {

        public ContentCategory(int contentId, int categoryId)
        {
            ContentId = contentId;
            CategoryId = categoryId;
        }


        public int ContentId { get; set; }

        public int CategoryId { get; set; }
    }
}
