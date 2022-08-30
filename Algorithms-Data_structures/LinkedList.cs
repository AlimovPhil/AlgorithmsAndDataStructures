using static Algorithms_Data_structures.LinkedList;

namespace Algorithms_Data_structures;

public class LinkedList : ILinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node? NextNode { get; set; }
        public Node PrevNode { get; set; }
        internal Node(int value) => Value = value;
    }

    private int Count;
    private Node? First;
    private Node? Last;

    public void PrintAllNodes()
    {
        Node current = First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.NextNode;
        }
    }
    public void AddNode(int value)
    {
        var node = new Node(value);

        Count++;

        if (First == null | Last == null)
        {
            First = node;
            Last = node;
        }
        else
        {
            node.PrevNode = Last;
            Last.NextNode = node;
            Last = node;
        }
    }

    public void AddNodeAfter(Node position, int value)
    {
        var node = new Node(value)
        {
            PrevNode = position,
            NextNode = position.NextNode,
        };

        Count++;

        position.NextNode = node;
        node.NextNode.PrevNode = node;
    }

    public int GetCount()
    {
        return Count;
    }

    public void RemoveNode(Node node)
    {
        if (ReferenceEquals(First, Last)) //один узел в списке
        {
            First = null;
            Last = null;
            Count = 0;
            return;
        }
        if (ReferenceEquals(node, First)) //удаление первого узла
        {
            First = node.NextNode;
            First.PrevNode = null;
            Count--;
            return;
        }

        if (ReferenceEquals(node, Last)) //удаление последнего узла
        {
            Last = node.PrevNode;
            Last!.NextNode = null;
            Count--;
            return;
        }
        else
        {
            node.PrevNode!.NextNode = node.NextNode;
            node.NextNode!.PrevNode = node.PrevNode;
            node.NextNode = null;
            node.PrevNode = null;

            Count--;
        }
    }
    public void RemoveNode(int index)
    {
        
        if (index > Count)
            throw new InvalidOperationException($"Элемент с индексом {index} не существует в этом списке.");
        if (index <= 0)
            throw new InvalidOperationException($"Укажите корректный номер элемента.");
        if (index == 1)
        {
            Node first = First;
            First = first.NextNode;
            First.PrevNode = null;
            Count--;
            return;
        }
        if (index == Count)
        {
            Node last = Last;
            Last = last.PrevNode;
            Last!.NextNode = null;
            Count--;
            return;
        }

        Node current = First;
        for (int i = 1; i <= index && current != null; i++)
        {
            if (i != index)
            {
                current = current.NextNode;
                continue;
            }
            RemoveNode(current);
        }

    }

    public Node FindNode(int searchValue)
    {
        Node current = First;
        while (current.Value != searchValue)
        {
            current = current.NextNode;
        }
        return current;
    }
}

public interface ILinkedList
{
    /// <summary>
    /// Возвращает количество элементов в списке
    /// </summary>
    int GetCount();

    /// <summary>
    /// добавляет новый элемент в конец списка
    /// </summary>
    /// <param name="value">значение элемента</param>
    void AddNode(int value);

    /// <summary>
    /// добавляет новый элемент списка после определённого элемента
    /// </summary>
    /// <param name="position"></param>
    /// <param name="value"></param>
    void AddNodeAfter(Node position, int value); 

    /// <summary>
    /// удаляет элемент по порядковому номеру
    /// </summary>
    /// <param name="index"></param>
    void RemoveNode(int index); 

    /// <summary>
    /// удаляет указанный элемент
    /// </summary>
    /// <param name="node"></param>
    void RemoveNode(Node node);

    /// <summary>
    /// ищет элемент по его значению
    /// </summary>
    /// <param name="searchValue"></param>
    /// <returns></returns>
    Node FindNode(int searchValue);

    /// <summary>
    /// Вывод в консоль всех элементов списка
    /// </summary>
    public void PrintAllNodes();
}