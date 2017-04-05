using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindWaveReaderWPF
{
    public class LimitedQueue<T> : Queue<T>
    {
        public int Limit { get; set; }

        public LimitedQueue(int limit) : base(limit)
        {
            Limit = limit;
        }

        public new void Enqueue(T item)
        {
            while (Count >= Limit) Dequeue();
            base.Enqueue(item);
        }
    }
}
