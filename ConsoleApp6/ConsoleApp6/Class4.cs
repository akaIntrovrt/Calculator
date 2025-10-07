
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

using System.Runtime.InteropServices;

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
        public double Density { get; set; }
        public int Speed { get; set; }
        public int OceansNum { get; set; }
        public int ContinentsNum { get; set; }

        public Planet()
        {
            Name = "None";
            Size = 0;
            Distance = 0;
            Life = "None";
            Mass = "none";
            BasicWeather = "None";
            Atmosphere = "None";
            Density = 0;
            OceansNum = 0;
            ContinentsNum = 0;


        }

        public Planet(string name, int size, int distance, string life, string mass, string weather, string atmosphere, double density, int speed, int oceansNum, int continentsNum)
        {
            Name = name;
            Size = size;
            Distance = distance;
            Life = life;
            Mass = mass;
            BasicWeather = weather;
            Atmosphere = atmosphere;
            Density = density;
            Speed = speed;
            OceansNum = oceansNum;
            ContinentsNum = continentsNum;
        }
        public void RenameTo(string name)
        {
            Name = name;
        }
        public void ResizeTo(int size)
        {
            if (size > 40000)
                Size = size;
            else
                Console.WriteLine("\nРазмер не может быть меньше 40000\n");
        }
        public string GetInfo()
        {
            if(OceansNum == 0 && ContinentsNum == 0 && Life == "None")
               return $"Имя: {Name} \nДистанция от солнца: {Distance}м км  \nРазмер: {Size}  \nУ {Name} нет жизни на поверхности \nМасса: {Mass}  \nОбычная Погода: {BasicWeather}  \nАтмосфера: {Atmosphere}  \nПлотность атмосферы: {Density} кг/м  \nСкорость движения вокруг солнца: {Speed}км/час  \nУ {Name} нету океанов.  \nУ {Name} нету континентов";
            else
               return $"Имя: {Name} \nДистанция от солнца: {Distance}м км  \nРазмер: {Size}  \nЖизнь: {Life}  \nМасса: {Mass}  \nОбычная Погода: {BasicWeather}  \nАтмосфера: {Atmosphere}  \nПлотность атмосферы: {Density} кг/м  \nСкорость движения вокруг солнца: {Speed}км/час  \nКоличество океанов: {OceansNum}  \nКоличество континентов: {ContinentsNum}";
        }
} 
}