using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "7894", modelo: "modelo x1", imei: "111111", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("dio");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "456123", modelo: "modelo x6", imei: "6666666", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Udemy");

Console.WriteLine();