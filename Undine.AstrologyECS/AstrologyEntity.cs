using AstrologyECS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;

namespace UndineAstrologyECS
{
    public class AstrologyEntity : IUnifiedEntity
    {
        public Entity Entity { get; set; }

        public AstrologyEntity(Entity entity)
        {
            Entity = entity;
        }

        public void AddComponent<A>(in A component) where A : struct
        {
            Entity.AddComponent(new AstrologyComponentWrapper<A>(component));
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref Entity.GetComponent<AstrologyComponentWrapper<A>>().Component;
        }
        public void RemoveComponent<A>() where A : struct
        {
            // bool?
            Entity.RemoveComponentsOfType<AstrologyComponentWrapper<A>>();
        }
    }
}