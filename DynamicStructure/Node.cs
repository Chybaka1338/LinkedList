using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace DynamicStructure
{
    public class Node
    {
        internal Node prev;

        internal Node next;

        internal string item;

        public Node Previous => prev;

        public Node Next => next;

        public string Item => item;

        public Node(string item)
        {
            this.item = item;
        }
    }
}
