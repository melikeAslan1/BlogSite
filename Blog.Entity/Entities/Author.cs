using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("Authors")]
    public class Author : ModelBase, IEntity
    {


        [StringLength(150)]
        public string FulName { get; set; }

        [StringLength(200)]
        public string Mail { get; set; }

        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(200)]
        [NotMapped]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }


    }
}
