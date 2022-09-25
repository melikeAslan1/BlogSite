using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Helper
{
    public static class EnvHelper
    {
        public static string ConnectionString { get; } = Environment.GetEnvironmentVariable("connectionstring") ?? "username=landingform_user;password=AVNS_Y8At_Ro7K-X57nP7emL;host=db-postgresql-ams3-41785-do-user-11154186-0.b.db.ondigitalocean.com;port=25061;database=Pool-Landingform;SSL Mode=Require;Trust Server Certificate=true;Pooling = true";
    }
}
