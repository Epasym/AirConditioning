using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCon
{

    internal class Room
    {
        private string name;
        private float temp;

        public Room(string name, float temp)
        {
            this.name = name;
            this.temp = temp;
        }

        public Room() {
            this.name = "room";
            this.temp = 25f;
        }

        public float Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
