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