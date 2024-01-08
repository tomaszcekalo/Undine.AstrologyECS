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
        private Entity _entity;

        public AstrologyEntity(Entity entity)
        {
            _entity = entity;
        }

        public void AddComponent<A>(in A component) where A : struct
        {
            _entity.AddComponent(new AstrologyComponentWrapper<A>(component));
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref _entity.GetComponent<AstrologyComponentWrapper<A>>().Component;
        }
    }
}