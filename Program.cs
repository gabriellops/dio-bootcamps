using dio_rgp_oop.src.Entities;

Tank garen = new Tank("Garen", 17, "Tank", 3000, 0);
Assassin kayn = new Assassin("Kayn", 17, "Assassin", 2500, 600);
Wizard lux = new Wizard("Lux", 16, "Wizard", 1900, 1700);
Marksman caitlyn = new Marksman("Caitlyn", 18, "Marksman", 2200, 980);
Support pyke = new Support("Pyke", 17, "Support", 2500, 900);


Console.WriteLine(garen);
Console.WriteLine($@"Name: {garen.Name}, Type: {garen.HeroType}, Level: {garen.Level}, HP: {garen.HP} and MP: {garen.MP}.");
Console.WriteLine(garen.Attack(0));
Console.WriteLine(garen.UltimateAbility(3));  