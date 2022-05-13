public class DepthFirstTraversal
{

    public DepthFirstTraversal()
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
        Console.WriteLine("Depth First Traversal:");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        Console.Write("\nIn-order Data   :");
        InOrderTraversal(tree.Root);
        Console.Write("\nPre-order Data  :");
        PreOrderTraversal(tree.Root);
        Console.Write("\nPost-order Data :");
        PostOrderTraversal(tree.Root);
    }

    public void InOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            this.InOrderTraversal(node.Left);
            Console.Write("  " + node.Data);
            this.InOrderTraversal(node.Right);
        }
    }

    public void PreOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            Console.Write("  " + node.Data);
            this.PreOrderTraversal(node.Left);
            this.PreOrderTraversal(node.Right);
        }
    }

    public void PostOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            this.PostOrderTraversal(node.Left);
            this.PostOrderTraversal(node.Right);
            Console.Write("  " + node.Data);
        }
    }
}