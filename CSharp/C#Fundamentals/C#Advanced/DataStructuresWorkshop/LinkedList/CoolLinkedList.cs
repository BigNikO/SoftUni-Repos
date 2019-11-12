namespace LinkedList
{
    using System;

    public class CoolLinkedList
    {
        private CoolNode head;
        private CoolNode tail;

        public int Count { get; private set; }

        public void AddFirst(object head)
        {
            var node = new CoolNode(head);

            if (this.Count == 0)
            {
                this.head = this.tail = node;
            }
            else
            {
                var currentHead = this.head;
                currentHead.Prev = node;
                currentHead.Prev.Next = this.head;
                this.head = node;
            }
            this.Count++;
        }

        public void AddLast(object value)
        {
            var node = new CoolNode(value);
            if (this.Count == 0)
            {
                this.tail = this.head = node;
            }
            else
            {
                var currentTail = this.tail;
                currentTail.Next = node;
                currentTail.Next.Prev = this.tail;
                this.tail = node;
            }
            this.Count++;
        }

        public object RemoveFirst()
        {
            ValidateIfListIsEmpty();
            var result = this.head.Value;
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newHead = new CoolNode(this.head.Next.Value);
                newHead.Next = this.head.Next.Next;
                this.head = newHead;
                this.Count--;
            }

            return result;
        }
        public object RemoveLast()
        {
            ValidateIfListIsEmpty();
            var result = this.tail.Value;
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newTail = new CoolNode(this.tail.Prev.Value);
                newTail.Prev = this.tail.Prev.Prev;
                this.tail = newTail;
                this.Count--;
            }

            return result;
        }

        public object[] ToArray()
        {
            var currentElement = this.head;
            var result = new object[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                result[i] = currentElement.Value;
                currentElement = currentElement.Next;
            }
            return result;
        }

        public void ForEach(Action<object> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        private void ValidateIfListIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CooLinkedList is empty.");
            }
        }
    }
}
