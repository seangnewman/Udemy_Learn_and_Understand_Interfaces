using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEnumerable_Pt1
{

    
    class TreeNodeEnumerator : IEnumerator<TreeNode>
    {
        private List<TreeNode> Traversal;
        private int CurrentIndex;

        public TreeNodeEnumerator(TreeNode root )
        {
            Traversal = root.PreorderTraversal();
            CurrentIndex = -1;
        }


        public TreeNode Current {
            get
            {
                return Traversal[CurrentIndex];
            }
       
        }
        object IEnumerator.Current {

            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            Traversal = null;
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return (CurrentIndex < Traversal.Count);
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }
    }
}
