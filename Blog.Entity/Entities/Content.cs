using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("Contents")]
    public class Content : ModelBase, IEntity
    {
        public Content()
        {
            IsActive = false;
            IsDeleted = false;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            PublishDate = DateTime.Now;
        }


        public virtual Media Media { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(60)]
        public string MetaTitle { get; set; }

        [StringLength(160)]
        public string MetaDescription { get; set; }

        [StringLength(160)]
        public string Description { get; set; }

        public int MediaId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime PublishDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public int AutherId { get; set; }

        [StringLength(150)]
        public string Slug { get; set; }

        public virtual List<ContentCategory> ContentCategories { get; set; }

        public virtual List<ContentTag> ContentTags { get; set; }



    }
}
