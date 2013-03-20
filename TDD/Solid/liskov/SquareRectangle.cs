using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Rectangle
    {
        private int height;
        private int width; 

        public int Height 
        { 
            get { return height;  }
            set { height = value; }
        }

        public virtual void SetHeight(int height)
        {
            this.height = height; 
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public virtual void SetWidth(int width)
        {
            this.width = width;
        }
    }

    public class Square : Rectangle
    {
        public override void SetHeight(int height)
        {
            base.SetHeight(height);
            base.SetWidth(height);
        }

        public override void SetWidth(int width)
        {
            base.SetHeight(width);
            base.SetWidth(width);
        }
    }
}

