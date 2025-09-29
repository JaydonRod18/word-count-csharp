using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodrigues.WordCount.App15
{
    public class FullTree
    {
        public Node root = null;

        public int count = 0;

        public string output = "";

        public FullTree() { }

        public Node get_root()
        {
            return root;
        }

        public void processTheWord(string word)
        {
            Node wordAlreadyThere = findWord(word);

            if (wordAlreadyThere != null)
            {
                wordAlreadyThere.incrementCount(); return;
            }
            else
            {
                addNode(word);
            }
        }

        private void balanceTree()
        {
            int leftSubTreeCount = countNodes(root.left);
            int rightSubTreeCount = countNodes(root.right);

            if (leftSubTreeCount - rightSubTreeCount > 4)
                rotateRight();

            if (rightSubTreeCount - leftSubTreeCount < 4)
                rotateLeft();
        }

        public int countNodes(Node temp)
        {
            if (temp == null)
                return 0;

            int leftCount = countNodes(temp.left);
            int rightCount = countNodes(temp.right);


            return 1 + leftCount + rightCount;
        }

        private void rotateRight()
        {
            Node temp = root.left;
            root.left = temp.right;

            temp.right = _root;

            root = temp;
        }

        private void rotateLeft()
        {
            Node temp = root.right;

            root.right = temp.left;

            temp.left = root;

            root = temp;
        }
    }
}
