namespace DynamicStructure
{
    public class LinkedList
    {
        internal Node head;

        public Node First => head;

        public Node Last => head.prev;

        internal int count;

        public Node AddFirst(string item)
        {
            var node = new Node(item);
            if (head == null)
            {
                InsertInEmptyList(node);
            }
            else
            {
                InsertNodeBefore(head, node);
                head = node;
            }
            return node;
        }

        public Node AddLast(string item)
        {
            var node = new Node(item);
            if (head == null)
            {
                InsertInEmptyList(node);
            }
            else
            {
                InsertNodeBefore(head, node);
            }
            return node;
        }

        public Node Find(string item)
        {
            if(head == null)
            {
                throw new Exception("head is null");
            }

            var node = head;
            do
            {
                if (node.item == item)
                {
                    return node;
                }
                node = node.next;
            } while (node != head);
            return null;
        }

        public void Delete(string item)
        {
            var node = Find(item);
            node.prev.next = node.next;
            node.next.prev = node.prev;
            if(node == head)
            {
                head = node.next;
            }
            count--;
        }

        private void InsertInEmptyList(Node newNode)
        {
            head = newNode;
            head.prev = newNode;
            head.next = newNode;
            count++;
        }

        private void InsertNodeBefore(Node node, Node newNode)
        {
            newNode.next = node;
            newNode.prev = node.prev;

            node.prev.next = newNode;
            node.prev = newNode;
            count++;
        }

        public LinkedList()
        {

        }

        internal LinkedList(IEnumerable<Node> source)
        {
            foreach(var node in source)
            {
                AddLast(node.item);
            }
        }
    }
}