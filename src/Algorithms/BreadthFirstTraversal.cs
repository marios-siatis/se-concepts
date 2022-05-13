public class BreadthFirstTraversal
{
    public BreadthFirstTraversal()
    {
        var tree = new BinaryTree();
        int[] arr = {
            1 , 2 , 3 , 4 , 5 , 6 , 7
        };
        var size = arr.Length;
        tree.Root = tree.BuildBinaryTree(arr, size, 0);

        /*
		           1
		         /   \
		        2     3
		       / \   /  \
		      4   5 6    7
		*/

        Console.Clear();
        Console.WriteLine("Breadth First Traversal:");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        Queue<TreeNode> q = new Queue<TreeNode>();

        q.Enqueue(tree.Root);

        while (q.Count > 0)
        {
            var current = q.Dequeue();
            if (current == null)
                continue;
            Console.WriteLine(current.Data);
            q.Enqueue(current.Left);
            q.Enqueue(current.Right);
        }
    }
}