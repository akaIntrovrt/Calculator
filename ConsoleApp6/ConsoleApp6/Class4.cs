
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
    public class Continents
    {
        public string Asia { get; set; }
        public double AsiaSize { get; set; }
        public string Australia { get; set; }
        public double AustraliaSize { get; set; }
        public string Antarctica { get; set; }
        public double AntarcticaSize { get; set; }
        public string Europe { get; set; }
        public double EuropeSize { get; set; }
        public string NorthAmerica { get; set; }
        public double NorthAmericaSize { get; set; }
        public string SouthAmerica { get; set; }
        public double SouthAmericaSize { get; set; }

        public Continents()
        {
            Asia = "Азия";
            AsiaSize = 44.6;
            Australia = "Австралия";
            AustraliaSize = 8.6;
            Antarctica = "Антарктика";
            AntarcticaSize = 14.1;
            Europe = "Европа";
            EuropeSize = 10.2;
            NorthAmerica = "Северная Америка";
            NorthAmericaSize = 24.7;
            SouthAmerica = "Южная Америка";
            SouthAmericaSize = 17.8;
        }
    }
    public class Climat
    {
        public string Equatorial { get; set; }
        public int EquatorialTemp { get; set; }
        public string Tropical { get; set; }
        public int Tropicaltemp { get; set; }
        public string Subtropical { get; set; }
        public int SubtropicalTemp { get; set; }
        public string Temparate { get; set; }
        public int TemparateTemp { get; set; }
        public string Continental { get; set; }
        public int ContinentalTemp { get; set; }

        public Climat()
        {
            Equatorial = "Экваториальный климат";
            EquatorialTemp = 25;
            Tropical = "Тропический климат";
            Tropicaltemp = 20;
            Subtropical = "Субтропический климат";
            SubtropicalTemp = 15;
            Temparate = "Умеренный климат";
            TemparateTemp = 10;
            Continental = "Континентальный климат";
            ContinentalTemp = 7;
        }
    }
    public class Oceans
    {
        public string Pacific { get; set; }
        public double PacificSize { get; set; }
        public string Indian { get; set; }
        public double IndianSize { get; set; }
        public string Arctic { get; set; }
        public double ArcticSize { get; set; }
        public string Atlantic { get; set; }
        public double AtlanticSize { get; set; }

        public Oceans()
        {
            Pacific = "Тихий океан";
            PacificSize = 168.7;
            Indian = "Индийский океан";
            IndianSize = 70.6;
            Arctic = "Актический океан";
            ArcticSize = 15.5;
            Atlantic = "Атлантический океан";
            AtlanticSize = 85.1;
        }
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
            public Continents continents { get; set; }
            public Oceans oceans { get; set; }
            public Climat climat { get; set; }

    public Planet()
            {
                Name = "Earth";
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
                return $"Имя: {Name} \nДистанция от солнца: {Distance}м км  \nРазмер: {Size}  \nЖизнь: {Life}  \nМасса: {Mass}  \nОбычная Погода: {BasicWeather}  \nАтмосфера: {Atmosphere}  \nПлотность атмосферы: {Density} кг/м  \nСкорость движения вокруг солнца: {Speed}км/час  \nКоличество океанов: {OceansNum}  \nКоличество континентов: {ContinentsNum} \nКонтиненты планеты: {Name} \n{continents.Asia} | {continents.AsiaSize}м км² \n{continents.Australia} | Площадь: {continents.AustraliaSize}м км² \n{continents.Antarctica} | Площадь: {continents.AntarcticaSize}м км² \n{continents.Europe} | Площадь: {continents.EuropeSize}м км² \n{continents.NorthAmerica} | Площадь: {continents.NorthAmericaSize}м км² \n{continents.SouthAmerica} | Площадь: {continents.SouthAmericaSize}м км² \n\nОкеаны планеты: {Name} \n{oceans.Pacific} | Площадь: {oceans.PacificSize}м км² \n{oceans.Indian} | Площадь: {oceans.IndianSize}м км² \n{oceans.Arctic} | Плозадь: {oceans.ArcticSize}м км² \n{oceans.Atlantic} | Площадь: {oceans.AtlanticSize}м км²";
            }
        
        }
    }
   
       }