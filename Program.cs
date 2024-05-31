using SimpleSinglyLinkedList;
internal class Program
{
    private static void Main()
    {
        SimpleLinkedList<int> linkedList = new();

        linkedList.InsertAtBeggining(1);
        linkedList.InsertAtBeggining(2);
        linkedList.InsertAtBeggining(3);
        linkedList.DeleteFromBeginning();

        linkedList.PrintList();
    }
}