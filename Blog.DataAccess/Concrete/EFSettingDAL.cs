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
    public class EFSettingDAL : EntityBaseData<Setting>, ISettingDal
    {
        public EFSettingDAL(DataContext context) : base(context)
        {
        }
    }
}
