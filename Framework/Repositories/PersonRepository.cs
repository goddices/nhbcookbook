using NHibernateCookbook.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCookbook.Framework.Repositories
{
    public interface IPersonRepository : IRepository<Person, int>
    {
    }
}
