using Microsoft.Extensions.Caching.Memory;

namespace BusTicket.Core.AOP.Cashing
{
    public interface IMemoryCache: IDisposable
    {
        ICacheEntry CreateEntry(object key);
        void Remove(object key);
        bool TryGetValue(object key, out object value);
    }
}
