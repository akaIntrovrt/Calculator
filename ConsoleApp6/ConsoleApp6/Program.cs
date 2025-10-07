namespace fProj
{
    public class Point2D
    {
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        public string Name { get; set; }



        public Point2D(int x, int y, string name)
        {
            PosX = x;
            PosY = y;
            Name = name;
        }


        public Point2D(int x, int y)
        {
            PosX = x;
            PosY = y;
            Name = "Dot";
        }

        public Point2D()
        {
            PosX = PosY = 0;
            Name = "Dot";
        }

        public void MoveTo(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        public void MoveTo(Point2D point)
        {
            PosX = point.PosX;
            PosY = point.PosY;
        }


        public string GetInfo()
        {
            return $"{Name}: {PosX} - {PosY}";
        }
    }
}