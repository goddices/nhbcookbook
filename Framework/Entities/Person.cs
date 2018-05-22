using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCookbook.Framework.Entities
{
    public class Person : IEntity
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual int Age { get; set; }
        public virtual String IdNo { get; set; }
    }
}
