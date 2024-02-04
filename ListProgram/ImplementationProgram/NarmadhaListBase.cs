using static ImplementationProgram.NarmadhaList<T>;

namespace ImplementationProgram
{
    public class NarmadhaListBase<T>
    {
        private object head;

        void Delete(Node del)
        {
            if (head == null || del == null)
            {
                return;
            }
            if (head == del)
            {
                head = del.Next;
            }

            if (del.Next != null)
            {
                del.Next.Previous = del.Previous;
            }
            if (del.Previous != null)
            {
                del.Previous.Next = del.Next;
            }
            return;
        }
    }
}