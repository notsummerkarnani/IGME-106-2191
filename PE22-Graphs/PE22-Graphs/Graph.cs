using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Samar Karnani
 * GDAPS 2 PE 23 Graph Searching
 * Prof E. Cascioli / Prof Alberto
 * 19/04/20 
 */

namespace PE22_Graphs
{
    class Graph
    {
        private Dictionary<string, Vertex> roomsDict;
        private List<Vertex> rooms;
        int[,] adjMatrix = new int[5, 5]// 5x5 2D array
        {
            {0, 1, 0, 0, 0},        //order of matrix matches the indices of the rooms list
            {1, 0, 1, 1, 0},
            {0, 1, 0, 1, 0},
            {0, 1, 1, 0, 1},
            {0, 0, 0, 1, 0}
        };

        public Graph()
        {
            //initialises variables
            roomsDict = new Dictionary<string, Vertex>();
            rooms = new List<Vertex>();

            //creates vertices and adds them to the list of rooms
            rooms.Add(new Vertex("Billiards Room", "A room to play billiards"));
            rooms.Add(new Vertex("Drawing Room", "A room to draw in"));
            rooms.Add(new Vertex("Game Room","A room to play games in"));
            rooms.Add(new Vertex("Library", "A room to read books in"));
            rooms.Add(new Vertex("Exit", "The way out"));

            //adds the rooms and their adj rooms to the adjacency list
            roomsDict.Add(rooms[0].RoomName, rooms[0]);
            roomsDict.Add(rooms[1].RoomName, rooms[1]);
            roomsDict.Add(rooms[2].RoomName, rooms[2]);
            roomsDict.Add(rooms[3].RoomName, rooms[3]);
            roomsDict.Add(rooms[4].RoomName, rooms[4]);
        }

        /// <summary>
        /// searches for all vertices using a stack
        /// If the parameter doesnt exist it doesnt run further
        /// otherwise it loops till all rooms have been displayed
        /// </summary>
        /// <param name="room"></param>
        public void DepthFirst(string room)
        {
            if(!roomsDict.ContainsKey(room))    //checks if room exists
            {
                Console.WriteLine("Room does not exist!");
                return;
            }

            Reset();    //resets all visited fields
            Stack<Vertex> path = new Stack<Vertex>();
            path.Push(roomsDict[room]); //adds the vertex to the stack
            Console.WriteLine(room);
            roomsDict[room].Visited = true;

            while(path.Count>0) //loop
            {
                if(GetAdjacentUnvisited(path.Peek().RoomName) == null)  //checks if there is an unvisited room
                {
                    path.Pop(); //if not it removes the top element of the stack
                }
                else
                {
                    Vertex temp = GetAdjacentUnvisited(path.Peek().RoomName);   //finds the unvisited room
                    path.Push(temp);        //adds it to the stack
                    temp.Visited = true;    //sets it as visited
                    Console.WriteLine(temp.RoomName);   //prints out the room name 
                }
            }
        }


        /// <summary>
        /// Chekcs if the room exists
        /// If it exists, it looks for an unvisited adjacent vertex using the ajacency matrix 
        /// </summary>
        /// <param name="room"> room whose adjacent vertex we want to find</param>
        /// <returns> first unvisited adjacent vertex found</returns>
        public Vertex GetAdjacentUnvisited(string room)
        {
            if(roomsDict.ContainsKey(room))  //checks if the room exists
            {
                for(int i = 0; i<5; i++)
                {
                    if(adjMatrix[roomsDict.Keys.ToList<string>().IndexOf(room), i] == 1 && rooms[i].Visited == false)
                    {
                        return rooms[i];
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// lists all the rooms present in the list
        /// </summary>
        public void ListAllVertices()
        {
            foreach(Vertex value in rooms)
            {
                Console.WriteLine(value.ToString());
                Console.WriteLine();
            }
        }

        /// <summary>
        /// iterates through all vertices and sets their visited field to false
        /// </summary>
        public void Reset()
        {
            foreach(Vertex vertex in rooms) 
            {
                vertex.Visited = false;
            }
        }


        //properties
        public List<Vertex> Rooms { get { return rooms; } }
    }
}
