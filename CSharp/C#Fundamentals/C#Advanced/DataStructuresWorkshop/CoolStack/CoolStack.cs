using System;
using System.Collections.Generic;
using System.Linq;

namespace CoolStack
{
    public class CoolStack
    {
        private object[] values;
        private int count;

        public int Count
        {
            get => this.count;
            private set => this.count = value;
        }


        public CoolStack()
            : this(16)
        {
        }

        public CoolStack(int initialCapacity)
        {
            this.Count = 0;
            this.values = new object[initialCapacity];
        }

        public void Push(object value)
        {
            if (this.count == this.values.Length)
            {
                var newValues = this.values.Concat(new object[count]).ToArray();
                this.values = new object[newValues.Length];
                this.values = newValues;

            }
            this.values[this.count] = value;
            this.Count++;
        }

        public object Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cool stack is empty");
            }
            var lastIndex = this.Count - 1;
            var last = this.values[this.Count - 1];
            this.values[lastIndex] = null;
            this.Count--;
            return last;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.values[i]);
            }
        }
    }
}

//private List<object> values;
//public int Count
//{
//    get => this.values.Count;
//}

//public CoolStack()
//{
//    this.values = new List<object>();
//}

//public void Push(object value)
//{
//    this.values.Add(value);
//}
//public object Pop()
//{
//    if (this.values.Count==0)
//    {
//        throw new InvalidOperationException("Cool stack is empty");
//    }
//    var lastIndex = this.values.Count - 1;
//    var last = this.values[lastIndex];
//    this.values.RemoveAt(lastIndex);
//    return last;
//}
