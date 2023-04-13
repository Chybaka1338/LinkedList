using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicStructure
{
    public static partial class EnumerableExtensions
    {
        public static LinkedList ToLinkedList(this IEnumerable<Node> source) 
        {
            if(source == null)
                throw new ArgumentNullException("source is null");

            foreach(var node in source)
            {
                if(node == null)
                {
                    throw new ArgumentNullException("node is null");
                }
                else if (String.IsNullOrEmpty(node.item))
                {
                    throw new ArgumentNullException("item null or empty");
                }
            }

            return new LinkedList(source);
        }
    }
}
