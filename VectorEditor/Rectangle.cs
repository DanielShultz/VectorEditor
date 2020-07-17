namespace VectorEditor
{
    class Rectangle
    {
        public int x1, y1;
        public int x2, y2;
        public int height;
        public int width;

        public Rectangle(int x1, int y1, int x2, int y2)
        {   
            if (x1<x2)
            {
                this.x1 = x1;
                this.x2 = x2;
            }
            else
            {
                this.x1 = x2;
                this.x2 = x1;
            }
            if (y1<y2)
            {
                this.y1 = y1;
                this.y2 = y2;
            }
            else
            {
                this.y1 = y2;
                this.y2 = y1;
            }    
            this.width = this.x2 - this.x1;
            this.height = this.y2 - this.y1;
        }
    }
}
