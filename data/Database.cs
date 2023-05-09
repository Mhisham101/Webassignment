using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaintballProject.Controllers
{
    internal class PaintballDbContext
    {
        public object Players { get; internal set; }

        internal object Play(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        internal void Play(object playerToRemove)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
