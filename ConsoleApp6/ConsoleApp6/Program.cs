using fProj;

Planet Jupiter = new Planet("Jupiter", 71492, 778, "None", "1 octillion", "Storms","Имеется",0.16, 47000, 0, 0);
Planet Earth = new Planet("Earth", 12742, 150, "This planet has Life", "5 siptillion", "Moderate Weather","Имеется",1.225,107000, 5, 7);

Jupiter.ResizeTo(399999);

Console.WriteLine(Jupiter.GetInfo());
Console.WriteLine("\n");
Console.WriteLine(Earth.GetInfo());