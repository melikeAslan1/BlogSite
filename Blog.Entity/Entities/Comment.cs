using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("Comments")]
    public class Comment : ModelBase, IEntity
    {


        public int ContentId { get; set; }

        [StringLength(150)]
        public string FullName { get; set; }

        [StringLength(250)]
        public string Mail { get; set; }

        [StringLength(1500)]
        public string Text { get; set; }

        public bool IsApproved { get; set; }




    }
}
