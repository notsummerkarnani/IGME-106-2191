using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE24__Dijkstras_Algorithm
{
    class Vertex
    {
        private string roomName;
        private string roomDescription;
        private int totalDist;
        private Vertex nearestneighbour;
        private bool permanent;

        public Vertex(string name, string description)
        {
            roomName = name;
            roomDescription = description;
            permanent = false;
        }

        public override string ToString()
        {
            return "Room: " + roomName + "\nDescription: " + roomDescription;
        }

        //properties
        public string RoomName { get { return roomName; } }

        public bool Permanent
        {
            get { return permanent; }
            set { permanent = value; }
        }

        public int TotalDist
        {
            get { return totalDist; }
            set { totalDist = value; }
        }
    }
}
