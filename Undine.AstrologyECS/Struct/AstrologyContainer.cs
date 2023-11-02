using AstrologyECS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.AstrologyECS.Struct;
using Undine.Core;
using Undine.Core.Struct;

namespace UndineAstrologyECS.Struct
{
    public class AstrologyContainer : EcsContainer
    {
        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            EntityPool.AddSystem(new AstrologySystem<A>(system));
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            EntityPool.AddSystem(new AstrologySystem<A, B>(system));
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            EntityPool.AddSystem(new AstrologySystem<A, B, C>(system));
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            EntityPool.AddSystem(new AstrologySystem<A, B, C, D>(system));
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            Entity entity = new Entity();
            EntityPool.AddEntity(entity);
            return new AstrologyEntity(entity);
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new AstrologySystem<A>(system);
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new AstrologySystem<A, B>(system);
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new AstrologySystem<A, B, C>(system);
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new AstrologySystem<A, B, C, D>(system);
        }

        public override void Run()
        {
            EntityPool.Tick();
        }
    }
}