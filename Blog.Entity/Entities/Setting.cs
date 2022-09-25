using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    [Table("Settings")]
    public class Setting : ModelBase, IEntity
    {
        
        [StringLength(200)]
        public string LogoPath { get; set; }

        [StringLength(60)]
        public string HomeMetaTitle { get; set; }

        [StringLength(160)]
        public string HomeMetaDescription { get; set; }

        [StringLength(100)]
        public string FtpUserName { get; set; }

        [StringLength(100)]
        public string FtpPassword { get; set; }

        [StringLength(100)]
        public string FtpSiteUrl { get; set; }

        [StringLength(100)]
        public string MediaBasePath { get; set; }
    }
}
