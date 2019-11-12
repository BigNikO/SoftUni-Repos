namespace LinkedList
{
    public class CoolNode
    {
        public CoolNode(object value)
        {
            this.Value = value;
        }

        public object Value  { get; private set; }
        public CoolNode Next { get; set; }
        public CoolNode Prev { get; set; }
    }
}
