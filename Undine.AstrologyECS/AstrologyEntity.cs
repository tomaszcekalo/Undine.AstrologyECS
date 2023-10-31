using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core.Class;

namespace Undine.AstrologyECS
{
    public class AstrologyEntity : IUnifiedEntity
    {
        public void AddComponent<A>(in A component) where A : class
        {
            throw new NotImplementedException();
        }

        public ref A GetComponent<A>() where A : class
        {
            throw new NotImplementedException();
        }
    }
}