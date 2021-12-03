using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE24__Dijkstras_Algorithm
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
            rooms.Add(new Vertex("Hallway", "A hallway"));
            rooms.Add(new Vertex("Drawing Room", "A room to draw in"));
            rooms.Add(new Vertex("Game Room", "A room to play games in"));
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
        /// Chekcs if the room exists
        /// If it exists, it looks for a non permanent adjacent vertex using the ajacency matrix 
        /// </summary>
        /// <param name="room"> room whose adjacent vertex we want to find</param>
        /// <returns> first unvisited adjacent vertex found</returns>
        public Vertex GetAdjacentUnvisited(string room)
        {
            if (roomsDict.ContainsKey(room))  //checks if the room exists
            {
                for (int i = 0; i < 5; i++)
                {
                    if (adjMatrix[roomsDict.Keys.ToList<string>().IndexOf(room), i] >= 1 && rooms[i].Permanent == false)
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
            foreach (Vertex value in rooms)
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
            foreach (Vertex vertex in rooms)
            {
                vertex.Permanent = false;
            }
        }

        public void ShortestPath(string source)
        {
            Vertex current = roomsDict[source];
            current.TotalDist = 0;
            current.Permanent = true;

            while(this.GetAdjacentUnvisited(current.RoomName) != null)
            {
                current = ShortestDistanceVertex(current.RoomName);
                current.Permanent = true;
            }
        }

        public Vertex ShortestDistanceVertex(string room)
        {
            Vertex shortest = null;
            for (int i = 0; i < 5; i++)
            {
                if (adjMatrix[roomsDict.Keys.ToList<string>().IndexOf(room), i] >= 1 && rooms[i].Permanent == false)
                {
                    if (shortest == null)
                    {
                        shortest = rooms[i];
                    }
                    else
                    {
                        if(adjMatrix[rooms.IndexOf(roomsDict[room]), rooms.IndexOf(shortest)] 
                            > 
                            adjMatrix[rooms.IndexOf(roomsDict[room]), i])
                        {
                            shortest = rooms[i];
                        }
                    }
                }
            }

            return shortest;
        }


        //properties
        public List<Vertex> Rooms { get { return rooms; } }
    }
}
