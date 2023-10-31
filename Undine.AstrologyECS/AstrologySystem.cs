using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;

namespace Undine.AstrologyECS
{
    public class AstrologySystem<A> : ISystem
        where A : class
    {
        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }

    public class AstrologySystem<A, B> : ISystem
        where A : class
        where B : class
    {
        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }

    public class AstrologySystem<A, B, C> : ISystem
        where A : class
        where B : class
        where C : class
    {
        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }

    public class AstrologySystem<A, B, C, D> : ISystem
        where A : class
        where B : class
        where C : class
        where D : class
    {
        public void ProcessAll()
        {
            throw new NotImplementedException();
        }
    }
}