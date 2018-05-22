using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;

namespace NHibernateCookbook.Tools
{
    public static class NHDBGen
    {
        public static void UdpateDatabase()
        { 
            Console.WriteLine("Updating database with Nhibernate");
            Configuration nhConfig = new Configuration().Configure();
            var schemaExport = new SchemaExport(nhConfig);
            schemaExport.Create(true, true);
            Console.WriteLine("Update complete");
        }
    }
}