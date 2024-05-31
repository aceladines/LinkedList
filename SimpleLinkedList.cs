namespace SimpleSinglyLinkedList;

public class SimpleLinkedList<T>
{
    private Node<T>? Head { get; set; }

    public void InsertAtBeggining(T data)
    {
        Node<T> new_node = new() { Data = data };

        if (Head == null)
        {
            Head = new_node;
            return;
        }

        new_node.Next = Head;
        Head = new_node;

    }

    public void DeleteFromBeginning()
    {
        if (Head == null)
        {
            throw new NullReferenceException();
        }

        Head = Head.Next;
    }

    public void PrintList()
    {
        Node<T>? current = Head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}
