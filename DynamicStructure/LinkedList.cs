namespace DynamicStructure
{
    public class LinkedList
    {
        internal Node head;

        internal int count;

        public Node First => head;

        public Node Last => head.prev;

        public int Count => count;

        public Node AddFirst(string item)
        {
            var node = new Node(item);
            if (head == null)
            {
                InternalInsertNodeToEmptyList(node);
            }
            else
            {
                InternalInsertNodeBefore(head, node);
                head = node;
            }
            return node;
        }

        public Node AddLast(string item)
        {
            var node = new Node(item);
            if (head == null)
            {
                InternalInsertNodeToEmptyList(node);
            }
            else
            {
                InternalInsertNodeBefore(head, node);
            }
            return node;
        }

        public Node Find(string item)
        {
            if(count == 0)
            {
                return null;
            }

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
            Node node;
            if((node = Find(item)) == null)
            {
                return;
            }

            if (count == 1)
            {
                head = null;
                count--;
                return;
            }

            node.prev.next = node.next;
            node.next.prev = node.prev;
            if (node == head) head = node.next;
            count--;
        }

        private void InternalInsertNodeToEmptyList(Node newNode)
        {
            newNode.next = newNode;
            newNode.prev = newNode;
            head = newNode;
            count++;
        }

        private void InternalInsertNodeBefore(Node node, Node newNode)
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