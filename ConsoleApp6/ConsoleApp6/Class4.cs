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
        public string PlanetName { get; set; }


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
            PlanetName = "Earth";
            new Continents();
            new Oceans();
            new Climat();
        }

        public Planet(string name, int size, int distance, string life, string mass, string weather, string atmosphere, double density, int speed, int oceansNum, int continentsNum, string planetName )
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
            PlanetName = planetName;
            new Continents();
            new Oceans();
            new Climat();

        }

        public class Continents
        {
            public static string[] Continent { get; set; }
            public static double[] ContinentSize { get; set; }
            public Continents()
            {
                Continent = new string[] { "Asia", "Europe", "Africa", "Antarctica", "North America", "South America" };
                ContinentSize = new double[] { 44.6, 10.2, 30.3, 14.0, 24.7, 17.8 };
            }
        }
        public class Climat
        {
            public static string[] Climats { get; set; }
            public static int[] ClimatsTemp { get; set; }

            public Climat()
            {
                Climats = new string[] { "Tropical", "Desert", "Temparate", "Continental", "Polar" };
                ClimatsTemp = new int[] { 25, 35, 15, 7, 0 };
            }
        }
        public class Oceans
        {
            public static string[] Ocean { get; set; }
            public static double[] OceanSize { get; set; }
            public static int[] OceanTemp { get; set; }

            public Oceans()
            {
                Ocean = new string[] { "Pacific Ocean", "Atlantic Ocean", "Arctic Ocean", "indian Ocean" };
                OceanSize = new double[] { 168.7, 85.1, 70.6, 20.3, 14.1 };
                OceanTemp = new int[] { 19, 16, 17, 2, 0 };
            }   
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
        public void GetInfo()
        {
            Console.WriteLine( $"Имя: {Name} \nДистанция от солнца: {Distance}м км \nРазмер: {Size}  \nЖизнь: {Life}  \nМасса: {Mass}  \nОбычная Погода: {BasicWeather}   \nАтмосфера: {Atmosphere}   \nПлотность атмосферы: {Density} кг/м   \nСкорость движения вокруг солнца: {Speed}км/час  \nКоличество океанов: {OceansNum}  \nКоличество континентов: {ContinentsNum}");

            Console.WriteLine("\n\nКонтиненты: ");
            for (int i = 0; i < Continents.Continent.Length; i++)
            {
                Console.WriteLine(Continents.Continent[i] + " -> " + " | Площадь: " + Continents.ContinentSize[i] + "млн км^2");
            }
            Console.WriteLine("\n\nКлиматы: ");
            for (int j = 0; j < Climat.Climats.Length; j++)
            {
                Console.WriteLine(Climat.Climats[j] + " -> " + " | Средняя темп: " + Climat.ClimatsTemp[j] + "C");
            }
            Console.WriteLine("\n\nОкеаны: ");
            for (int s = 0; s < Oceans.Ocean.Length; s++)
            {
                Console.WriteLine(Oceans.Ocean[s] + " -> " + " Средняя темп: " + Oceans.OceanTemp[s] + "C" + " | Площадь: " + Oceans.OceanSize[s] + "млн км^2");
            }

        }

    } 
}