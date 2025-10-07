
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

namespace fProj 
{

    public class Planet
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public int Size { get; set; }
        public string Life { get; set; }
        public string Mass { get; set; }
        public string BasicWeather { get; set; }
        public string Atmosphere { get; set; }

        public Planet()
        {
            Name = "None";
            Size = 0;
            Distance = 0;
            Life = "None";
            Mass = "none";
            BasicWeather = "None";
            Atmosphere = "None";
        }

        public Planet(string name, int size, int distance, string life, string mass, string weather, string atmosphere)
        {
            Name = name;
            Size = size;
            Distance = distance;
            Life = life;
            Mass = mass;
            BasicWeather = weather;
            Atmosphere = atmosphere;
        }
        public void RenameTo(string name, int distance, int size, string life, string mass, string weather, string atmosphere)
        {
            Name = name;
            Distance = distance;
            Size = size;
            Life = life;
            Mass = mass;
            BasicWeather = weather;
            Atmosphere = atmosphere;

        }
        public string GetInfo()
        {
            return $"Имя: {Name}: \nДистанция от солнца: {Distance}м км  \nРазмер: {Size}  \nЖизнь: {Life}  \nМасса: {Mass}  \nОбычная Погода: {BasicWeather}  \nАтмосфера: {Atmosphere}";
        }
} 
}