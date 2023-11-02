using AstrologyECS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;
using Undine.Core.Struct;

namespace UndineAstrologyECS.Struct
{
    public class AstrologySystem<A> : AstrologyECS.System, ISystem
        where A : struct
    {
        public UnifiedSystem<A> System { get; set; }

        public AstrologySystem(UnifiedSystem<A> system)
        {
            System = system;
        }

        protected override ComponentFilter Filter => new ComponentFilter()
            .AddNecessary(typeof(AstrologyComponentWrapper<A>));

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void OperateOnEntity(Entity entity)
        {
            var a = entity.GetComponent<AstrologyComponentWrapper<A>>();
            System.ProcessSingleEntity(0, ref a.Component);
        }
    }

    public class AstrologySystem<A, B> : AstrologyECS.System, ISystem
        where A : struct
        where B : struct
    {
        public UnifiedSystem<A, B> System { get; set; }

        protected override ComponentFilter Filter => new ComponentFilter()
            .AddNecessary(typeof(AstrologyComponentWrapper<A>))
            .AddNecessary(typeof(AstrologyComponentWrapper<B>));

        public AstrologySystem(UnifiedSystem<A, B> system)
        {
            System = system;
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void OperateOnEntity(Entity entity)
        {
            var a = entity.GetComponent<AstrologyComponentWrapper<A>>();
            var b = entity.GetComponent<AstrologyComponentWrapper<B>>();
            System.ProcessSingleEntity(0, ref a.Component, ref b.Component);
        }
    }

    public class AstrologySystem<A, B, C> : AstrologyECS.System, ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; set; }

        protected override ComponentFilter Filter => new ComponentFilter()
            .AddNecessary(typeof(AstrologyComponentWrapper<A>))
            .AddNecessary(typeof(AstrologyComponentWrapper<B>))
            .AddNecessary(typeof(AstrologyComponentWrapper<C>));

        public AstrologySystem(UnifiedSystem<A, B, C> system)
        {
            System = system;
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void OperateOnEntity(Entity entity)
        {
            var a = entity.GetComponent<AstrologyComponentWrapper<A>>();
            var b = entity.GetComponent<AstrologyComponentWrapper<B>>();
            var c = entity.GetComponent<AstrologyComponentWrapper<C>>();
            System.ProcessSingleEntity(0, ref a.Component, ref b.Component, ref c.Component);
        }
    }

    public class AstrologySystem<A, B, C, D> : AstrologyECS.System, ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; set; }

        protected override ComponentFilter Filter => new ComponentFilter()
            .AddNecessary(typeof(AstrologyComponentWrapper<A>))
            .AddNecessary(typeof(AstrologyComponentWrapper<B>))
            .AddNecessary(typeof(AstrologyComponentWrapper<C>))
            .AddNecessary(typeof(AstrologyComponentWrapper<D>));

        public AstrologySystem(UnifiedSystem<A, B, C, D> system)
        {
            System = system;
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void OperateOnEntity(Entity entity)
        {
            var a = entity.GetComponent<AstrologyComponentWrapper<A>>();
            var b = entity.GetComponent<AstrologyComponentWrapper<B>>();
            var c = entity.GetComponent<AstrologyComponentWrapper<C>>();
            var d = entity.GetComponent<AstrologyComponentWrapper<D>>();
            System.ProcessSingleEntity(0, ref a.Component, ref b.Component, ref c.Component, ref d.Component);
        }
    }
}