using _300960704_DaSilva_ASS04.Exception;
using System.Collections.Generic;

namespace _300960704_DaSilva_ASS04.DataStructure
{
    public class Stack<T>
    {
        private List<T> m_stack = new List<T>();

        public T Pop()
        {
            if (m_stack.Count == 0)
            {
                throw new EmptyDataStructureException("Cannot Pop from an empty stack.");
            }

            var itemPopped = m_stack[m_stack.Count - 1];
            m_stack.RemoveAt(m_stack.Count - 1);
            return itemPopped;
        }

        public bool IsEmpty()
        {
            return m_stack.Count == 0;
        }

        public void Push(T item)
        {
            m_stack.Add(item);
        }
    }
}
