using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicStructure
{
    public static class LinkedListExtenstions
    {
        public static IEnumerable<Node> EnumeratesNode(this LinkedList list)
        {
            var node = list.head;
            while(node != null)
            {
                yield return node;
                node = node.next;
            }
        }
    }
}
