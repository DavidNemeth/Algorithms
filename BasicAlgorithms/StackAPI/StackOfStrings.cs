using System;

namespace StackAPI
{
    public class StackOfStrings
    {       
        private Node first = null;

        private class Node
        {
            internal string item;
            internal Node next;
        }

        public bool isEmpty()
        {
            return first == null;
        }

        public void push(string item)
        {
            Node oldfirst = first;
            first = new Node();
            first.item = item;
            first.next = oldfirst;
        }

        public string pop()
        {
            string item = first.item;
            first = first.next;
            return item;
        }
    }
}
