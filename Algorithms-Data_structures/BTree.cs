using static Algorithms_Data_structures.BTree;

namespace Algorithms_Data_structures;

public class BTree : ITree
{
    private TreeNode _Root;
    private readonly int _Size;

    public TreeNode Root { get => _Root; set => _Root = value; }
    public int Size { get; set; }

    public class TreeNode
    {
        private int _Value;
        private TreeNode _LeftChild;
        private TreeNode _RightChild;

        public int Value { get => _Value; set => _Value = value; }
        public TreeNode LeftChild { get => _LeftChild; set => _LeftChild = value; }
        public TreeNode RightChild { get => _RightChild; set => _RightChild = value; }
        public TreeNode Parent { get; set; }

        public TreeNode(int value) => Value = value;

        public TreeNode(int value, TreeNode left, TreeNode right, TreeNode parent)
        {
            Value = value;
            LeftChild = left;
            RightChild = right;
            Parent = parent;
        }

        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;
            if (node == null)
                return false;
            return node.Value == Value;
        }
    }

    public void AddItem(int value)
    {
        if (value == null) throw new ArgumentNullException("Отсутствует значение!");

        var node = new TreeNode(value);
        if (Root == null)
        {
            Root = node;
        }
        else
        {
            TreeNode current = Root, parent = null;

            while (current != null)
            {
                parent = current;
                if (value.CompareTo(current.Value) < 0)
                {
                    current = current.LeftChild;
                }
                else current = current.RightChild;
            }

            if (value.CompareTo(parent.Value) < 0)
            {
                parent.LeftChild = node;
            }
            else parent.RightChild = node;
        }
        ++Size;
    }

    public TreeNode GetNodeByValue(int value, TreeNode root)
    {
        if (root == null || value == root.Value)
            return root;
        else if (root.Value > value)
            return GetNodeByValue(value, root.LeftChild);
        else
            return GetNodeByValue(value, root.RightChild);
    }

    public void DFS(BTree tree)
    {
        if (tree.Root == null)
            return;
        var stack = new Stack<TreeNode>();
        stack.Push(tree.Root);
        while (stack.Count != 0)
        {
            TreeNode curr = stack.Pop();
            Console.Write($">{curr.Value} ");
            if (curr.LeftChild != null)
            {
                stack.Push(curr.LeftChild);
            }
            if (curr.RightChild != null)
            {
                stack.Push(curr.RightChild);
            }
        }
    }

    public void BFS(BTree tree)
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(Root);
        while (q.Count > 0)
        {
            TreeNode current = q.Dequeue();
            if (current == null)
                continue;
            q.Enqueue(current.LeftChild);
            q.Enqueue(current.RightChild);

            Console.Write($">{current.Value} ");
        }
    }

    public TreeNode GetRoot()
    {
        throw new NotImplementedException();

    }
    public int PrintTree(TreeNode node, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(node.Value);

        var loc = y;

        if (node.RightChild != null)
        {
            Console.SetCursorPosition(x + 2, y);
            Console.Write("--");
            y = PrintTree(node.RightChild, x + 4, y);
        }

        if (node.LeftChild != null)
        {
            while (loc <= y)
            {
                Console.SetCursorPosition(x, loc + 1);
                Console.Write(" |");
                loc++;
            }
            y = PrintTree(node.LeftChild, x, y + 2);
        }

        return y;
    }
    public TreeNode RemoveItem(int deleteData, TreeNode root)
    {
        if (root == null)
            return root;
        if (deleteData < root.Value)
        {
            root.LeftChild = RemoveItem(deleteData, root.LeftChild);
        }
        else if (deleteData > root.Value)
        {
            root.RightChild = RemoveItem(deleteData, root.RightChild);
        }
        else if (root.LeftChild != null && root.RightChild != null)
        {
            root.Value = Minimum(root.RightChild).Value;
            root.RightChild = RemoveItem(root.Value, root.RightChild);
        }
        else if (root.LeftChild != null)
        {
            return root.LeftChild;
        }
        else
        {
            return root.RightChild;
        }

        return root;
    }
    public TreeNode Minimum(TreeNode root)
    {
        if (root != null)
        {
            if (root.LeftChild != null) root = Minimum(root.LeftChild);
        }
        return root;
    }
}

public interface ITree
{
    TreeNode GetRoot();
    void AddItem(int value); // добавить узел
    TreeNode RemoveItem(int value, TreeNode root); // удалить узел по значению
    TreeNode GetNodeByValue(int value, TreeNode root); //получить узел дерева по значению
    int PrintTree(TreeNode node, int x, int y); //вывести дерево в консоль
}