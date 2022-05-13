using System;

public class TreeNode
{
    public int Data;
    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int data)
    {
        // Set node value
        this.Data = data;
        this.Left = null;
        this.Right = null;
    }
}

public class BinaryTree
{
    public TreeNode Root;
    public BinaryTree()
    {
        // Set initial tree root
        this.Root = null;
    }

    public TreeNode BuildBinaryTree(int[] arr, int size, int location)
    {
        if (location >= size)
        {
            return null;
        }
        // Create new node
        var head = new TreeNode(arr[location]);
        // build left subtree
        head.Left = this.BuildBinaryTree(arr, size, (location * 2) + 1);
        // build right subtree
        head.Right = this.BuildBinaryTree(arr, size, (location * 2) + 2);
        return head;
    }
}