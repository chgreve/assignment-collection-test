using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    internal class StackTester<T> : BaseCollection<T>
    {
        Stack<T> stack = new Stack<T>();
        public override int Count()
        {
            return stack.Count;
        }

        public override T FirstObject()
        {
            return stack.First();
        }

        public override T LastObject()
        {
            return stack.Last();
        }

        protected override void FillCollectionInternal(string[] input, Func<string, T> func)
        {
            foreach (var item in input) 
                stack.Push(func(item));
        }

        protected override void PrintCollectionInternal(TextWriter writer)
        {
            foreach(var item in stack) writer.WriteLine(item);
        }

        protected override void SortCollectionInternal(Func<T, T> comparer)
        {
            stack = new Stack<T>(stack.OrderByDescending(comparer));
        }
    }
}
