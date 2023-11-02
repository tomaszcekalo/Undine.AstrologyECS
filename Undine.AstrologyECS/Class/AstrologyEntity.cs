using AstrologyECS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndineAstrologyECS;
using Undine.Core.Class;

namespace UndineAstrologyECS.Class
{
    public class AstrologyEntity : IUnifiedEntity
    {
        private Entity _entity;

        public AstrologyEntity(Entity entity)
        {
            _entity = entity;
        }

        public void AddComponent<A>(in A component) where A : class
        {
            _entity.AddComponent(new AstrologyComponentWrapper<A>(component));
        }

        public ref A GetComponent<A>() where A : class
        {
            return ref _entity.GetComponent<AstrologyComponentWrapper<A>>().Component;
        }
    }
}