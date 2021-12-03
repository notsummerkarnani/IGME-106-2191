using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;

/* Samar Karnani   
 * Gdaps 2 HW5 Quad Trees
 * Prof E. Cascioli / Prof Alberto / Jake!
 * 4/20
 */

namespace QuadTreeStarter
{
	class QuadTreeNode
	{
		#region Constants
		// The maximum number of objects in a quad
		// before a subdivision occurs
		private const int MAX_OBJECTS_BEFORE_SUBDIVIDE = 3;
		#endregion

		#region Variables
		// The game objects held at this level of the tree
		private List<GameObject> _objects;

		// This quad's rectangle area
		private Rectangle _rect;

		// This quad's divisions
		private QuadTreeNode[] _divisions;
		#endregion

		#region Properties
		/// <summary>
		/// The divisions of this quad
		/// </summary>
		public QuadTreeNode[] Divisions { get { return _divisions; } }

		/// <summary>
		/// This quad's rectangle
		/// </summary>
		public Rectangle Rectangle { get { return _rect; } }

		/// <summary>
		/// The game objects inside this quad
		/// </summary>
		public List<GameObject> GameObjects { get { return _objects; } }
		#endregion

		#region Constructor
		/// <summary>
		/// Creates a new Quad Tree
		/// </summary>
		/// <param name="x">This quad's x position</param>
		/// <param name="y">This quad's y position</param>
		/// <param name="width">This quad's width</param>
		/// <param name="height">This quad's height</param>
		public QuadTreeNode(int x, int y, int width, int height)
		{
			// Save the rectangle
			_rect = new Rectangle(x, y, width, height);

			// Create the object list
			_objects = new List<GameObject>();

			// No divisions yet
			_divisions = null;
		}
		#endregion

		#region Methods
		/// <summary>
		/// Adds a game object to the quad.  If the quad has too many
		/// objects in it, and hasn't been divided already, it should
		/// be divided
		/// </summary>
		/// <param name="gameObj">The object to add</param>
		public void AddObject(GameObject gameObj)
		{
            // ACTIVITY: Complete this method
            if (this._rect.Contains(gameObj.Rectangle))
            {
                if(this._divisions != null)     //checks if current rect has been divided 
                {
                    if (this._divisions[0]._rect.Contains(gameObj.Rectangle))    //checks if a division can hold the obj
                    {
                        this._divisions[0].AddObject(gameObj); // if it can hold the obj the method is called recursively
                        //Console.WriteLine("Added");       debugging
                    }
                    else if (this._divisions[1]._rect.Contains(gameObj.Rectangle))    //checks if a division can hold the obj
                    {
                        this._divisions[1].AddObject(gameObj); // if it can hold the obj the method is called recursively
                        //Console.WriteLine("Added");       debugging
                    }
                    else if (this._divisions[2]._rect.Contains(gameObj.Rectangle))    //checks if a division can hold the obj
                    {
                        this._divisions[2].AddObject(gameObj); // if it can hold the obj the method is called recursively
                        //Console.WriteLine("Added");       debugging
                    }
                    else if (this._divisions[3]._rect.Contains(gameObj.Rectangle))    //checks if a division can hold the obj
                    {
                        this._divisions[3].AddObject(gameObj); // if it can hold the obj the method is called recursively
                        ////Console.WriteLine("Added");       debugging       debugging
                    }
                    else
                    {
                        this._objects.Add(gameObj); //adds to this quad if divisions exist but it doesnt fit in any division
                    }
                }
                else
                {
                    this._objects.Add(gameObj);     //if no divisions exist its added to this quad
                    //Console.WriteLine("Added");       debugging
                    Console.ReadLine();
                    if (this._objects.Count>MAX_OBJECTS_BEFORE_SUBDIVIDE)   //checks if divide is necessary
                    {
                        this.Divide();
                        //Console.WriteLine("Divide");       debugging
                    }
                }
            }
		}

		/// <summary>
		/// Divides this quad into 4 smaller quads.  Moves any game objects
		/// that are completely contained within the new smaller quads into
		/// those quads and removes them from this one.
		/// </summary>
		public void Divide()
		{
            // ACTIVITY: Complete this method

            //creates 4 child nodes
            QuadTreeNode child1 = new QuadTreeNode(this.Rectangle.X, this.Rectangle.Y, this.Rectangle.Width / 2, this.Rectangle.Height / 2);
            QuadTreeNode child2 = new QuadTreeNode(this.Rectangle.X + this.Rectangle.Width / 2, this.Rectangle.Y , this.Rectangle.Width / 2, this.Rectangle.Height / 2);
            QuadTreeNode child3 = new QuadTreeNode(this.Rectangle.X, this.Rectangle.Y + this.Rectangle.Height / 2, this.Rectangle.Width / 2, this.Rectangle.Height / 2);
            QuadTreeNode child4 = new QuadTreeNode(this.Rectangle.X + this.Rectangle.Width / 2, this.Rectangle.Y + this.Rectangle.Height / 2, this.Rectangle.Width / 2, this.Rectangle.Height / 2);

            //adds nodes to parent divisions list
            this._divisions = new QuadTreeNode[4];
            this._divisions[0] = child1;
            this._divisions[1] = child2;
            this._divisions[2] = child3;
            this._divisions[3] = child4;

            //moves objects into divisions if they fit
            foreach(QuadTreeNode division in _divisions)
            {
                for(int i = 0; i< this._objects.Count; i++)
                {
                    if(division._rect.Contains(this._objects[i].Rectangle))
                    {
                        //Console.WriteLine("\ndivision rectangle contains parent object");  debugging
                        division._objects.Add(this._objects[i]);
                        //Console.WriteLine("Moved succesfully");   debugging
                        this._objects.RemoveAt(i);
                        i--;
                    }
                }
            }

        }

		/// <summary>
		/// Recursively populates a list with all of the rectangles in this
		/// quad and any subdivision quads.  Use the "AddRange" method of
		/// the list class to add the elements from one list to another.
		/// </summary>
		/// <returns>A list of rectangles</returns>
		public List<Rectangle> GetAllRectangles()
		{
			List<Rectangle> rects = new List<Rectangle>();

            // ACTIVITY: Complete this method
            rects.Add(this._rect);      //adds to list
            if(this._divisions != null)
            {
                for(int i = 0; i<4; i++)
                {
                    rects.AddRange(this._divisions[i].GetAllRectangles());  //calls the method till all the rectangles have been added
                }
            }
			return rects;
		}

		/// <summary>
		/// A possibly recursive method that returns the
		/// smallest quad that contains the specified rectangle
		/// </summary>
		/// <param name="rect">The rectangle to check</param>
		/// <returns>The smallest quad that contains the rectangle</returns>
		public QuadTreeNode GetContainingQuad(Rectangle rect)
		{
            // ACTIVITY: Complete this method
            if (this._rect.Contains(rect) && this._divisions != null)
            {
                //checks all the divisions recursively to see which smallest rectangle can hold it
                for(int i = 0; i<this._divisions.Length; i++)
                {
                    if(this._divisions[i]._rect.Contains(rect))
                    {
                        return _divisions[i].GetContainingQuad(rect);
                    }
                }
                return this;    //returns parent if none of the divisions hold it
            }
            else if(this._rect.Contains(rect))      //if no divisions exist
            {
                return this;
            }
			// Return null if this quad doesn't completely contain
			// the rectangle that was passed in
			return null;
		}
		#endregion
	}
}
