using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    internal class LinkedListTester<T> : BaseCollection<T>
    {
        private LinkedList<T> list = new LinkedList<T>();
        protected override void FillCollectionInternal(string[] input, Func<string, T> func)
        {
            foreach(var item in input)
                list.AddFirst(func(item));
        }

        protected override void SortCollectionInternal(Func<T, T> comparer)
        {
            list = new LinkedList<T>(list.OrderBy(comparer));
            
        }

        protected override void PrintCollectionInternal(TextWriter writer)
        {
            foreach (var item in list) writer.WriteLine(item);
        }

        public override T FirstObject()
        {
            return list.First();
        }

        public override T LastObject()
        {
            return list.Last();
        }

        public override int Count()
        {
            return list.Count();
        }

    }
}
