using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndineAstrologyECS
{
    public class AstrologyComponentWrapper<T> : AstrologyECS.Component
    {
        public AstrologyComponentWrapper(T component)
        {
            Component = component;
        }

        public T Component;
    }
}