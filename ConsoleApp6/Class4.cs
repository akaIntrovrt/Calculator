
//namespace fProj
//{
//    public class Point2D
//    {
//        public int PosX { get; private set; }
//        public int PosY { get; private set; }
//        public string Name { get; set; }



//        public Point2D(int x, int y, string name)
//        {
//            PosX = x;
//            PosY = y;
//            Name = name;
//        }


//        public Point2D(int x, int y)
//        {
//            PosX = x;
//            PosY = y;
//            Name = "Dot";
//        }

//        public Point2D()
//        {
//            PosX = PosY = 0;
//            Name = "Dot";
//        }

//        public void MoveTo(int x, int y)
//        {
//            PosX = x;
//            PosY = y;
//        }

//        public void MoveTo(Point2D point)
//        {
//            PosX = point.PosX;
//            PosY = point.PosY;
//        }


//        public string GetInfo()
//        {
//            return $"{Name}: {PosX} - {PosY}";
//        }
//    }
//}


using System;

public class Planet
{
    public Planet()
    {
        public string Name { get; set; }
    public string Distance { get; set; }
    public string Size { get; set; }

    public Planet(string name, string distance, string size)
    {
        Name = "Jupiter";
        Distance = distance;
        Size = size;
    }
    public Planet()
    {
        Size = "71492km";
        Distance = "714m killometers"
    }
    public void RenameTo(string name, string distance, string size)
    {
        Name = name;
        Distance = distance;
        Size = size;
    }
    public string GetInfo()
    {
        return $"{Name}: {Distance} | {Size}";
    }
}
}