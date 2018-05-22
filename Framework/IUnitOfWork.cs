using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCookbook.Framework
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();

        void Begin();
        void End();
    }
}
