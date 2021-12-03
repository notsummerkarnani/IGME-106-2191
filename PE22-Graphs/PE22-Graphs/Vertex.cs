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
    class Vertex
    {
        private string roomName;
        private string roomDescription;
        private bool visited;

        public Vertex(string name, string description)
        {
            roomName = name;
            roomDescription = description;
            visited = false;
        }

        public override string ToString()
        {
            return "Room: " + roomName + "\nDescription: " + roomDescription;
        }

        //properties
        public string RoomName { get { return roomName; } }

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }
    }
}
