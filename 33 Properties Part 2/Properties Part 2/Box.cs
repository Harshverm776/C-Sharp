using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Part_2
{
    class Box
    {
        private int length;
        public int height;

        //properties

        // public int Length{ get; set; }
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }
        public Box()
        {

        }
        public Box(int height, int length)
        {
            this.height = height;
            Length = length;
        }
    }
}
