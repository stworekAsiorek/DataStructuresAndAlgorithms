using System.Collections.Concurrent;

namespace DataStructuresAndAlgorithms.Practice
{
    public class LastTenHelper
    {
        private const int limit = 10;
        private readonly ConcurrentDictionary<string, FixedSizeQueue<decimal>> data = new();

        public void Add(string name, decimal price)
        {
            FixedSizeQueue<decimal> fixedSizeQueue = data.AddOrUpdate(name, key => { var queue = new FixedSizeQueue<decimal>(limit); queue.Enqueue(price); return queue; }, (key, oldValue) => { oldValue.Enqueue(price); return oldValue; }) ;
        }

        public IList<decimal> GetLastTenPrices(string name)
        {
            var lastTenPrices = new List<decimal>();
            if (data.TryGetValue(name, out FixedSizeQueue<decimal>? fixedSizeQueue))
            {
                lastTenPrices = fixedSizeQueue.GetContent();
            }
            return lastTenPrices;
        }

    }

    public class FixedSizeQueue<T>
    {
        private readonly int limit;
        private readonly ConcurrentQueue<T> queue = new ConcurrentQueue<T>();
        private readonly ManualResetEvent _mre = new ManualResetEvent(true); 
        private readonly object _lock = new object();
        public FixedSizeQueue(int _limit)
        {
            limit = _limit;
        }

        public void Enqueue(T obj)
        {
            lock (_lock)
            {
                _mre.Reset();
                queue.Enqueue(obj);
                while (queue.Count > limit && queue.TryDequeue(out _)) ;
                _mre.Set();
            }
        }

        public List<T> GetContent()
        {
            _mre.WaitOne();
            return queue.ToList();
        } 
    }
}
