using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class person
    {
        int id;
        //main info
        private int arrival;
        private int interarrival;
        private int servicetime;
        private int delay;
        private int beginservice;
        private int leave;
        private int totalwait;

        private bool done;

        //draw info
        private Point location;
        private Color col;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int Arrival
        {
            get
            {
                return arrival;
            }
            set
            {
                arrival = value;
            }
        }

        public int InterArrival
        {
            get
            {
                return interarrival;
            }
            set
            {
                interarrival = value;
            }
        }

        public int ServiceTime
        {
            get
            {
                return servicetime;
            }
            set
            {
                servicetime = value;
            }
        }

        public int Delay
        {
            get
            {
                return delay;
            }
            set
            {
                delay = value;
            }
        }

        public int BeginService
        {
            get
            {
                return beginservice;
            }
            set
            {
                beginservice = value;
            }
        }

        public int Leave
        {
            get
            {
                return leave;
            }
            set
            {
                leave = value;
            }
        }

        public int TotalWait
        {
            get
            {
                return totalwait;
            }
            set
            {
                totalwait = value;
            }
        }

        public Point Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public Color Col
        {
            get
            {
                return col;
            }
            set
            {
                col = value;
            }
        }

        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }

        public person()
        {
            done = false;
        }
    }
}
