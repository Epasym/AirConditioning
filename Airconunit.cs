using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCon
{
    internal class Airconunit
    {
        private string name;
        private int targettemp;
        private bool cooling;
        private bool on;
        private int maxtemp;
        private int mintemp;
        private int power;

        public Airconunit(string name, int maxtemp, int mintemp, int power)
        {
            this.name = name;
            this.maxtemp = maxtemp;
            this.mintemp = mintemp;
            this.on = false;
            this.cooling = true;
            this.targettemp = 25;
            this.power = power;
        }

        public Airconunit()
        {
            this.name = "AirCon";
            this.maxtemp = 30;
            this.mintemp = 18;
            this.on = false;
            this.cooling = true;
            this.targettemp = 25;
            this.power = 5;
        }

        public void StartStop() {
            if (on)
            {
                on = false;
            }
            else
            {
                on = true;
            }
        }

        public void CoolHeat()
        {
            if (cooling)
            {
                cooling = false;
            }
            else
            {
                cooling = true;
            }
        }

        public void TempUp()
        {
            if (targettemp <= maxtemp)
            {
                targettemp += 1;
            }
        }

        public void PowerDown() {
            if (targettemp >= mintemp)
            {
                targettemp -= 1;
            }
        }

        public float ConditionRoom(float currenttemp)
        {
            float tempchange = 0;
            if (on)
            {
                if(cooling)
                {
                    if(currenttemp > targettemp)
                    {
                        tempchange -= (float)1/ (2 * power);
                    }
                }
                else
                {
                    if(currenttemp < targettemp)
                    {
                        tempchange += (float)1 / (2 * power);
                    }
                }
            }
            return tempchange;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value;}
        }

        public int Targettemp
        {
            get { return targettemp; }
            set { this.targettemp = value; }
        }

        public bool Cooling
        {
            get { return cooling; }
            set { cooling = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public int Maxtemp
        {
            get { return Maxtemp; }
            set { Maxtemp = value; }
        }
    }
}
