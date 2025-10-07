using fProj;

Planet Jupiter = new Planet("Jupiter", 71492, 778, "None", "1 octillion", "Storms","None");
Planet Earth = new Planet("Earth", 12742, 150, "This planet has Life", "5 siptillion", "Moderate Weather","Имеется");

Console.WriteLine(Jupiter.GetInfo());
Console.WriteLine("\n");
Console.WriteLine(Earth.GetInfo());