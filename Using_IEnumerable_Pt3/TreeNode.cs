﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEnumerable_Pt3
{
    class TreeNode: IEnumerable<TreeNode>
    {

        // The data contained in this node.
        public string Data { get; set; }

        // The node's child nodes
        public List<TreeNode> Children = new List<TreeNode>();

        // Constructor
        public TreeNode(string data)
        {
            Data = data;
        }

        // Return the in-order traversal of this node's subtree
        public List<TreeNode> PreorderTraversal()
        {
            // Add this node
            List<TreeNode> result = new List<TreeNode>();
            result.Add(this);

            // Add the traversal of the subtree
            foreach (TreeNode child in Children)
            {
                result.AddRange(child.PreorderTraversal());
            }

            return result;
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            yield return this;

            foreach (TreeNode child in Children)
            {
                foreach (TreeNode node in child)
                {
                    yield return node;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
