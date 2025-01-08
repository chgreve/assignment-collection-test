using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    internal class DictionaryTester<T> : BaseCollection<T>
    {
        Dictionary<T, T> dic = new Dictionary<T, T>();

        public override int Count()
        {
            return dic.Count;
        }

        public override T FirstObject()
        {
            return dic.First().Value;
        }

        public override T LastObject()
        {
            return dic.Last().Value;
        }

        protected override void FillCollectionInternal(string[] input, Func<string, T> func)
        {
            foreach(var item in input)
            {
                dic[func(item)] = func(item);
            };
        }

        protected override void PrintCollectionInternal(TextWriter writer)
        {
            foreach (var item in dic) writer.WriteLine(item);
        }

        protected override void SortCollectionInternal(Func<T, T> comparer)
        {
            dic = new Dictionary<T, T>(dic.OrderBy(x => x.Value));
        }
    }
}
