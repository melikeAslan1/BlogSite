using Blog.DataAccess.Abstract;
using Blog.DataAccess.Context;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete
{
    public class EFCommentDAL : EntityBaseData<Comment>, ICommentDal
    {
        public EFCommentDAL(DataContext context) : base(context)
        {
        }
    }
}
