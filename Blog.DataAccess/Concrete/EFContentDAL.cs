using Blog.DataAccess.Abstract;
using Blog.DataAccess.Context;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete
{
    public class EFContentDAL : EntityBaseData<Content>, IContentDal
    {
        public EFContentDAL(DataContext context) : base(context)
        {
        }
    }
}
