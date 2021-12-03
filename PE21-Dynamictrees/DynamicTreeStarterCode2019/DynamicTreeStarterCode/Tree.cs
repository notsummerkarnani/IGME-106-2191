using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/* Samar Karnani
 * PE21 Dynamic trees
 * Prof E. Cascioli / Prof. Alberto
 * 11/4/20
 */

namespace DynamicTreeStarterCode
{
	/// <summary>
	/// Represents a tree-centric data structure
	/// that can have data dynamically inserted, 
	/// and can be drawn as a literal "tree" on the screen
	/// </summary>
	class Tree : DrawableTree
	{
		// Already has an inherited root node field called "root"

		/// <summary>
		/// Creates a tree that can be drawn
		/// </summary>
		/// <param name="sb">The sprite batch used to draw</param>
		/// <param name="treeColor">The color of this tree</param>
		public Tree(SpriteBatch sb, Color treeColor)
			: base(sb, treeColor)
		{ }

		/// <summary>
		/// Public facing Insert method
        /// checks for a root node and creates one if it isnt there
        /// if a root node exists it calls the priv method
		/// </summary>
		/// <param name="data">The data to insert</param>
		public void Insert(int data)
		{
            // *** Fill in this method ****************************************
            if (root == null)
            {
                root = new TreeNode(data);
            }
            else
            {
                Insert(data, root);
            }
		}

		/// <summary>
		/// Private recursive insert method
        /// checks if the data is greater than or smaller than the current node
        /// Moves left if it is smaller and right if it is greater
        /// if the child node doesn't exist, it creates a new node with tht data
		/// </summary>
		/// <param name="data">The data to insert</param>
		/// <param name="node">The node to attempt to insert into</param>
		private void Insert(int data, TreeNode node)
		{
			// *** Fill in this method ****************************************
			if (node.Data>data)
            {
                if (node.Left != null)
                { 
                    Insert(data, node.Left); 
                }
                else
                {
                    node.Left = new TreeNode(data);
                }
            }
            else
            {
                if (node.Right != null)
                {
                    Insert(data, node.Right);
                }
                else
                {
                    node.Right = new TreeNode(data);
                }
            }
		}
	}
}
