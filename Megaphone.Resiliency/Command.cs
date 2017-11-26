namespace Megaphone.Resiliency
{
    public abstract class Command<T>
    {
        public T Execute()
        {
            T res = Run();
            return res;
        }

        protected abstract T GetFallback();

        protected abstract T Run();

        public bool IsResponseFromCache { get; protected set; }

        protected abstract T GetCacheKey();
    }
}